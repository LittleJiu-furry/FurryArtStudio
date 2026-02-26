# 读取 vbproj 版本号
$vbproj = Get-ChildItem -Filter *.vbproj | Select-Object -First 1
[xml]$projXml = Get-Content $vbproj.FullName

$version = $projXml.Project.PropertyGroup.Version
if (-not $version) {
    Write-Host "Version not found in vbproj."
    exit 1
}

Write-Host "Detected version: $version"

$tagName = "v$version"

# 更新 CHANGELOG
$whatsNew = Get-Content .\WHATSNEW.txt -Raw
$changelog = ""

if (Test-Path .\CHANGELOG.txt) {
    $changelog = Get-Content .\CHANGELOG.txt -Raw
}

$newContent = $whatsNew.TrimEnd() + "`r`n`r`n" + $changelog.TrimStart()
Set-Content .\CHANGELOG.txt $newContent -Encoding UTF8

Write-Host "CHANGELOG updated."

# 提交
git add CHANGELOG.txt
git commit -m "Version $tagName"

# 创建 tag
git tag $tagName

# 推送
git push
git push origin $tagName

Write-Host "Release $tagName pushed successfully."