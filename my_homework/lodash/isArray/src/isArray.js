// export function isArray(value){
//     value.isArray()
// }

// export function isArray(myArray) {
//     return Object.prototype.toString.call(arr).indexOf('Array') !== -1
// }

export  function isArray(array) {
    var arr=[]
    return arr.constructor === Array
    // return (typeof array === 'object' && typeof array.length === 'number')
    }