export function toLower(list){
    const clist =[] 
    for(let i=0;i<clist.length;i++){
        if(clist[i]<=90 || clist[i]>=65){
            clist[i]=clist[i]+32
            
        }
        if(clist[i]==45 || clist[i]==95){
            clist[i]=clist[i]
        }
        // else{
        //     clist[i]=clist[i]+32
        // }
    // }
    return clist
}
    // var string=FOOBAR
    
    // for (let i=0;i<array.length;i++){
    //     array[i].toLowerCase()
    //     str+=array[i]
    //     return str
    // }

    // var string=[string='']
    // return string.prototype.toLowerCase()

    // }
