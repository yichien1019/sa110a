# 📝軟體工程與演算法第一週筆記20210915
## 👉成績評定
* 期中成績(=筆記) 30%
* 期末成績(=專案) 30%
* 平時成績(=隋堂作業) 40%

## 📖 課程內容
![](pic/sastart.JPG)
* 軟體工程
    * JavaScript
* 演算法
    * Deno
    * Plant UML
    * nginx
    * Docker
* 作業系統
    * C
    * RISC-V

## 📖 什麼是[軟體工程](https://zh.wikipedia.org/zh-tw/%E8%BD%AF%E4%BB%B6%E5%B7%A5%E7%A8%8B)
![](pic/sa.jpg)
* 軟體工程是一門研究用工程化方式建構和維護有效的、實用的和高質量的軟體的學科。他涉及到程式設計語言、資料庫、軟體開發工程、系統平台、標準、設計等模式方面。
### 🔖 模型簡介
#### [瀑布模型](https://zh.wikipedia.org/wiki/%E7%80%91%E5%B8%83%E6%A8%A1%E5%9E%8B)
![](pic/waterfallmode.JPG)
#### [螺旋模型](https://zh.wikipedia.org/wiki/%E8%9E%BA%E6%97%8B%E6%A8%A1%E5%9E%8B)
![](pic/spiralmode.png)

## 📖 GITHUB如何加入[ssh key設定](https://programmermedia.org/root/%E9%99%B3%E9%8D%BE%E8%AA%A0/%E6%8A%80%E8%83%BD/git.md)
* github 從 2021 年八月開始強制安裝 ssh key 提升安全性了
![](pic/ssh.JPG)
```
yichien@MSI MINGW64 /d/VScode/WP/ccc/110a/sa (master)
$ ssh-keygen -t rsa -C "yichien1019@gmail.com"

yichien@MSI MINGW64 /d/VScode/WP/ccc/110a/sa (master)
$ cat /c/Users/yichien/.ssh/id_rsa.pub
```
* 將公鑰複製下來，貼到Setting -> SSH and GPG keys -> New SSH key，完成設定
![](pic/sshkey.JPG)

## 📖 創建GITHUB 的 Organization
![](pic/organ.JPG)
1. 進入github的settings點擊organizations
2. 命名(不能重複)並創建，也可以邀請隊員進入組織

## 📖 補充資料
* [ccckmit 用20分鐘搞懂 《系統分析、軟體工程、專案管理與設計模式》](https://www.slideshare.net/ccckmit/20-57269452)

https://www.bigocheatsheet.com/


