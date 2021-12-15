# 📝軟體工程與演算法第十一週筆記20211124
## 📖 
### 🔖 
#### 📍 
## 💻 程式實際操作
### 🔗 
![](pic/)
<details>
  <summary><b>Show code</b></summary>

  ```
  ```
</details>

#### The result of execution
```
```

## 📖 補充資料


:

資料夾是一種特殊的inode(檔案)
一個block是1024bit
LN讓兩個位置不同的檔案指向相同倘案
https://github.com/riscv2os/riscv2os/wiki/xv6inode

檔案表的 0, 1, 2 格，一開始就被填入 STDIN, STDOUT, STDERR 的處理函數，對應到 console 的輸出入

邊準函示庫部會有012
https://github.com/riscv2os/riscv2os/wiki/xv6ftable
pipe  ==  cat a.txt | grep..... 中間直線為pipe
當我們用 read/write 去讀寫時，通常是讀取《檔案》，但也有可能是《裝置或 pipe》
必須注意的是， trampoline 在 kernel 和 user space 都被映射到同一個虛擬位址，所以切換時不用修改暫存器，這樣才能達到《無縫接軌》的效果。
https://github.com/riscv2os/riscv2os/wiki/xv6trampoline
呼叫 read() 時，行程會中斷換別人嗎？
回答：會！
https://github.com/riscv2os/riscv2os/wiki/xv6readyield