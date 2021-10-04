# 📝軟體工程與演算法第三週筆記20210929
## 📖 正規軍 V.S. 特種部隊
### 🔖 正規軍 (瀑布模式)
* 傳統模式，像是一些大公司，EX : Microsoft、IBM、CMMI
* 需求明確、技術能力夠，可以採用此模式
### 🔖 特種部隊 (螺旋模式)
* 敏捷開發，EX : Scrum、XP
* 高效率的面對面溝通、品質焦點

#### 📍 
## 📖 合作開發 (WORKFLOW)
### 🔖 GITHUB FLOW操作步驟
順序 | 主控者 | 貢獻者
---- | ----- | -----
1 | 創建專案 | 
2 | 創建分支 | 
3 |  | fork專案
4 |  | clone專案
5 |  | 修改程式
6 |  | 測試程式
7 |  | 創建分支
8 |  | 回推檔案
9 |  | 發pull resquest
10| 測試程式 | 
11| 收pull resquest | 
12| 合併分支到主要分支 | 

### 🔖 分支的創建與轉換
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
```

* 先使用fork，再將對方設定成upstream才能更新
```
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
* `git log` : 可以看到過去送出的版本紀錄
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
* [git / github 的用法](https://programmermedia.org/root/%E9%99%B3%E9%8D%BE%E8%AA%A0/%E6%8A%80%E8%83%BD/git.md)