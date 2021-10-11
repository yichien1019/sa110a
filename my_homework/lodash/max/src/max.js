export function max(array){
    var x;
    var max = array[0];
    for (x=0;x<array.length;x++){
        if(array[x+1]>array[x]){
            max=array[x+1];
            return max;
        }
        else if(array.lenght == 0){
            return undefined;
        }
        // else{
        //      continue;
        // }
     }
}

//     var len = array.length;
//     var max = array[0];
//     while(len--){   //如果 (i = i - 1) 大於 0，則繼續循環，否則退出
//         if(array[len]>max){
//             console.log("array.length",len);
//             max=array[len];
//         }
//         else{
//             max=max;
//         }
//     }
//     return max;
// }