param([string]$Imagen)
$ErrorActionPreference = 'Stop'
$solution = Split-Path $PSScriptRoot -Parent
$vswhere = Join-Path ${env:ProgramFiles(x86)} 'Microsoft Visual Studio/Installer/vswhere.exe'
if (!(Test-Path -LiteralPath $vswhere)) { throw 'No se encuentra vswhere; se requiere Visual Studio con MSBuild y .NET Framework 4.8.' }
$msbuild = & $vswhere -latest -products '*' -requires Microsoft.Component.MSBuild -find 'MSBuild\**\Bin\MSBuild.exe' | Select-Object -First 1
if (!$msbuild) { throw 'No se encuentra MSBuild de Visual Studio.' }
$compiler = Join-Path (Split-Path $msbuild -Parent) 'Roslyn/csc.exe'
if (!(Test-Path -LiteralPath $compiler)) { throw 'No se encuentra el compilador Roslyn junto a MSBuild.' }
& $msbuild (Join-Path $solution 'Compras.sln') /t:Build /p:Configuration=Debug /nologo /verbosity:minimal
if ($LASTEXITCODE) { throw 'Error de compilación de Compras.' }
$dll = Join-Path $solution 'CapaVista_Compras/bin/Debug/CapaVista_Compras.dll'
$testDir = Join-Path ([IO.Path]::GetTempPath()) ('ComprasComponentes-' + [Guid]::NewGuid())
New-Item -ItemType Directory -Path $testDir | Out-Null
$exe = Join-Path $testDir 'ComponentesComprasSmoke.exe'
$testDll = Join-Path $testDir 'CapaVista_Compras.dll'
try {
    & $compiler /nologo /target:exe "/out:$exe" "/reference:$dll" /reference:System.Windows.Forms.dll /reference:System.Drawing.dll /reference:System.Data.dll /reference:System.Design.dll (Join-Path $PSScriptRoot 'ComponentesComprasSmoke.cs')
    if ($LASTEXITCODE) { throw 'Error de compilación de las pruebas.' }
    Copy-Item -LiteralPath $dll -Destination $testDll
    if ($Imagen) { & $exe $Imagen }
    else { & $exe }
    if ($LASTEXITCODE) { throw 'Fallaron las comprobaciones de componentes.' }
}
finally {
    foreach ($file in @($exe, $testDll)) {
        if (Test-Path -LiteralPath $file) { Remove-Item -LiteralPath $file }
    }
    Remove-Item -LiteralPath $testDir
}
