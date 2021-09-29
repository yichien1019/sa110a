# 📝軟體工程與演算法第三週筆記20210929

## 📖 workflow
```

```

## 📖 GIT
## 📖 workflow

```
yichien@MSI MINGW64 /d/VScode/WP/ccc/110a/sa110a (master)
$ git branch
* master

yichien@MSI MINGW64 /d/VScode/WP/ccc/110a/sa110a (master)
$ git checkout -b add_code
Switched to a new branch 'add_code'

yichien@MSI MINGW64 /d/VScode/WP/ccc/110a/sa110a (add_code)
$ git branch
* add_code
  master 
  
yichien@MSI MINGW64 /d/VScode/WP/ccc/110a/sa110a (add_code)
$ git checkout master
Switched to branch 'master' 

yichien@MSI MINGW64 /d/VScode/WP/ccc/dsi2598- (add)
$ git remote add upstream https://github.com/Chen-Chun/dsi2598-.git

yichien@MSI MINGW64 /d/VScode/WP/ccc/dsi2598- (add)
$ git remote -v
origin  git@github.com:yichien1019/dsi2598-.git (fetch)
origin  git@github.com:yichien1019/dsi2598-.git (push)
upstream        https://github.com/Chen-Chun/dsi2598-.git (fetch)
upstream        https://github.com/Chen-Chun/dsi2598-.git (push)

yichien@MSI MINGW64 /d/VScode/WP/ccc/dsi2598- (add)
$ git fetch upstream
remote: Enumerating objects: 8, done.
remote: Counting objects: 100% (8/8), done.
remote: Compressing objects: 100% (5/5), done.
remote: Total 7 (delta 0), reused 7 (delta 0), pack-reused 0
Unpacking objects: 100% (7/7), 819 bytes | 1024 bytes/s, done.
From https://github.com/Chen-Chun/dsi2598-
 * [new branch]      add_boy    -> upstream/add_boy
 * [new branch]      add_girl   -> upstream/add_girl
 * [new branch]      main       -> upstream/main

yichien@MSI MINGW64 /d/VScode/WP/ccc/dsi2598- ((2ea3949...))
$ git checkout upstream/add_girl
HEAD is now at 2ea3949 add

yichien@MSI MINGW64 /d/VScode/WP/ccc/dsi2598- ((2ea3949...))
$ git pull upstream add_girl
From https://github.com/Chen-Chun/dsi2598-
 * branch            add_girl   -> FETCH_HEAD
Already up to date.
```
* `.gitignore` : 可以避免回傳這些類型的檔案
EX.
```
*.exe
*.zip
*.bak
bak
```


## 📖 補充資料
* [Git 工作流程](https://www.ruanyifeng.com/blog/2015/12/git-workflow.html)