// #region Task 1
// let arr1 = [1,2,3];
// let arr2 = [4,5,6];

// const ArrayConcat = (arr1, arr2) => {
//     var arrConcat = arr1.concat(arr2);
//     return arrConcat;
// } 

// console.log(ArrayConcat(arr1,arr2));

//#endregion

//#region Task 2

// const Months = (num) => {
//     const Months = ['january', 'February', 'March', 'April', 'May', 'June', 'July', 'August', 'September', 'October', 'November', 'December'];
//     if(num > 0 && num < 13) return Months[num-1];
//     else return "Number is not correct";
// }

// console.log(Months(12));

//#endregion

//#region Task 3

// const checkFactor = (arr, num) => {
//     return arr.every(element => num%element == 0)
// }

// console.log(checkFactor([2,3,5], 12));

// console.log(arr.every(element => element%1 == 0));

// console.log(CheckParticular([2,3,4,5], 1));



//#endregion

//#region Task 4

// var arr = [1,2,3,4,43];

// const CheckParticular = (arr, num) => {
    // variant 1
    // let returnValue = false;
    // arr.forEach(element => {
    //     if(element === num) returnValue = true;
    // });
    // return returnValue;

    // variant 2
    // return arr.some(element => element === num)

    // variant 3
//     return arr.includes(num)
// }

// console.log(CheckParticular([2,3,4,5], 1));
//#endregion

//#region Task 5
// const CreateArray = (numStart, numEnd, OfsetNumber) =>{
//     var Array = [];
//     for(let i = numStart; i <= numEnd; i+=OfsetNumber){
//         Array.push(i);
//     }
//     return Array
// }

// console.log(CreateArray(1000,1000));
//#endregion

//#region Task 6

// var Arr = [2,4,5,7,9,10,1,23,45,68,45,100,-3];

// Task 6.1
//-----------------------------------------------------------------------------------------
// const ShowArrElement = () => {
//     Arr.forEach(item => {
//         console.log(item);
//     })
// }

// Task 6.2
//-----------------------------------------------------------------------------------------
// console.log(Math.max(...Arr));


// Task 6.3
// Arr.push(15)
// console.log(Arr);

// Task 6.4
//-----------------------------------------------------------------------------------------
// Arr.shift();
// console.log(Arr);



// Task 6.5
//-----------------------------------------------------------------------------------------
// Arr.sort((a,b) => a-b);
// console.log(Arr);
// console.log(Arr[Arr.length-1]);




// Task 6.6
//-----------------------------------------------------------------------------------------
// Arr.splice(3,0, 43)
// console.log(Arr);



// Task 6.7
//-----------------------------------------------------------------------------------------
// variant 1
// for (let i = 3; i < Arr.length; i++) {
//     console.log(Arr[i]);
    
// }


// variant 2
// let newArr = Arr.slice(3)





// Task 6.8
//-----------------------------------------------------------------------------------------
// Arr.forEach(item => console.log(item))




// Task 6.9
//-----------------------------------------------------------------------------------------
// for(let i = 0; i < Arr.length; i++){
//     Arr[i] > 40 ? console.log(Arr[i]) : false ;
// }





// ShowArrElement(Arr)




//#endregion




