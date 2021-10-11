export function min(array){
    var x;
    var min = array[0];
    for (x=0;x<array.length;x++){
        if(array[x+1]<array[x]){
            min=array[x+1];
            return min;
        }
        else if(array.lenght == 0){
            return undefined;
        }
        // else{
        //      continue;
        // }
     }
}