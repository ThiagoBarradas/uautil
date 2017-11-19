# reference: http://www.codeproject.com/Tips/806257/Automating-NuGet-Package-Creation-using-AppVeyor
$root = (split-path -parent $MyInvocation.MyCommand.Definition)

$version = [System.Reflection.Assembly]::LoadFile("$root\UAUtil\bin\Release\netstandard2.0\UAUtil.dll").GetName().Version
$versionStr = "{0}.{1}.{2}" -f ($version.Major, $version.Minor, $version.Build)

Write-Host "Setting .nuspec version tag to $versionStr"

$content = (Get-Content $root\UAUtil\UAUtil.nuspec) 
$content = $content -replace '\$version\$',$versionStr

$content | Out-File $root\UAUtil.compiled.nuspec

& 