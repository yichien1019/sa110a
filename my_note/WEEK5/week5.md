有輸入產生亂數 雜湊
沒輸入產生亂數 
hash2 太簡單 
hashtable 大小固定127是質數 因為碰撞率
碰撞完全在2^256，預期第一次碰撞 2^128 幾乎可以確定sha不會碰撞
就算有問題 加倍2^512





digest
挖礦->猜數字
mining
足夠前導0->5個






```
yichien@MSI MINGW64 /d/VScode/WP/ccc/110a/sa/alg/07-hashing/sha (master)
$ deno run hash.js
Download https://deno.land/std/hash/mod.ts
Warning Implicitly using latest version (0.111.0) for https://deno.land/std/hash/mod.tsod.ts
Download https://deno.land/std@0.111.0/hash/mod.ts
Download https://deno.land/std@0.111.0/hash/hasher.ts
Download https://deno.land/std@0.111.0/hash/_wasm/hash.ts
Download https://deno.land/std@0.111.0/encoding/base64.ts
Download https://deno.land/std@0.111.0/hash/_wasm/wasm.js
Download https://deno.land/std@0.111.0/encoding/hex.ts
Check file:///D:/VScode/WP/ccc/110a/sa/alg/07-hashing/sha/hash.js
hash(hello)= 2cf24dba5fb0a30e26e83b2ac5b9e29e1b161e5c1fa7425e73043362938b9824     
hash(hello!)= ce06092fb948d9ffac7d1a376e404b26b7575bcc11ee05a4615fef4fec3a308b    889
hash(hello world !)= a4bf1f6be616bf6a0de2ff6264de43a64bb768d38c783ec2bc74b5d4dcf5f889
```