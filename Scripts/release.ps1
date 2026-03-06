# 定义
$assemblyInfo = Get-Content ".\My Project\AssemblyInfo.vb"
$whatsNewPath = ".\src\Docs\WHATSNEW.txt"
$changelogPath = ".\docs\CHANGELOG.txt"

# 读取版本号
$versionLine = $assemblyInfo | Where-Object { $_ -match "AssemblyVersion" }

if ($versionLine -match '"(\d+\.\d+\.\d+)\.\d+"') {
    $version = $matches[1]
}

Write-Host "Detected version: $version"

$tagName = "v$version"

# 更新 CHANGELOG
$whatsNew = Get-Content $whatsNewPath -Raw 
$changelog = ""

if (Test-Path $changelogPath) {
    $changelog = Get-Content $changelogPath -Raw
}

$newContent = $whatsNew.TrimEnd() + "`r`n`r`n" + $changelog.TrimStart()
Set-Content $changelogPath $newContent -Encoding UTF8

Write-Host "CHANGELOG updated."

# 提交
git add $changelogPath
git commit -m "Version $tagName"

# 创建 tag
git tag $tagName

# 推送
git push
git push origin $tagName

Write-Host "Release $tagName pushed successfully."