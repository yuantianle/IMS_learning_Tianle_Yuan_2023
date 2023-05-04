/*
1. We have an object storing salaries of our team
let salaries = {
John: 100,
Ann: 160,
Pete: 130
}
Write the code to sum all salaries and store in the variable sum. Should be 390 in the example above.
*/ 
console.log("Answer for Q1:")
let salaries = {
    John: 100,
    Ann: 160,
    Pete: 130
};
var sum = 0;
for (let key in salaries) {
    sum += salaries[key];
}
console.log("The sum is: ", sum, "\n");

/*
2. Create a function multiplyNumeric(obj) that multiplies all numeric properties of obj by 2
// before the call
let menu = {
width: 200,
height: 300,
title: "My menu"
};
multiplyNumeric(menu);
// after the call
menu = {
width: 400,
height: 600,
title: "My menu"
};
Please note that multiplyNumeric does not need to return anything. It should modify the object in-place
*/
console.log("Answer for Q2:")
function multiplyNumeric(obj){
    obj.width = 400;
    obj.height = 600;
    obj.title = "My menu";
}
let menu = {
    width: 200,
    height: 300,
    title: "My menu"
};
console.log("Before: ", menu);
multiplyNumeric(menu);
console.log("After: ", menu);
console.log();

/*
3. Write a function checkEmailId(str) that returns true if str contains '@' and ‘.’, otherwise false. Make sure
'@' must come before '.' and there must be some characters between '@' and '.'
The function must be case-insensitive:
*/
console.log("Answer for Q3:")
function checkEmailId(str){
    let at = str.indexOf('@');
    let dot = str.indexOf('.');
    if (!at || !dot){
        return false;
    }
    if(at < dot && at != -1 && dot != -1){
        return true;
    }
    else{
        return false;
    }
}
console.log("TEST1(\".#@\"): ", checkEmailId(".#@"));  // false
console.log("TEST2(\" /sds`@C.com\"): ", checkEmailId(" /sds`@.com"));  //true
console.log("TEST3(\"sds@com\"): ", checkEmailId("sds@com")); //false
console.log("TEST4(\"sds.com\"): ", checkEmailId("sds.com")); //false
console.log();

/*
4. Create a function truncate(str, maxlength) that checks the length of the str and, if it exceeds maxlength
– replaces the end of str with the ellipsis character "...", to make its length equal to maxlength.
The result of the function should be the truncated (if needed) string.
truncate("What I'd like to tell on this topic is:", 20) = "What I'd like to te..."
truncate("Hi everyone!", 20) = "Hi everyone!"
*/
console.log("Answer for Q4:")
function truncate(str, maxlength){
    if(str.length > maxlength){
        return str.slice(0, maxlength-1) + "...";
    }
    else{
        return str;
    }
}
console.log("TEST1(\"What I'd like to tell on this topic is:\", 20): ", truncate("What I'd like to tell on this topic is:", 20));
console.log("TEST2(\"Hi everyone!\", 20): ", truncate("Hi everyone!", 20));
console.log();

/*
5. Let’s try 5 array operations.
Create an array styles with items “James” and “Brennie”.
Append “Robert” to the end.
Replace the value in the middle by “Calvin”. Your code for finding the middle value should work for any
arrays with odd length.
Remove the first value of the array and show it.
Prepend Rose and Regal to the array.
James, Brennie
James, Brennie, Robert
James, Calvin, Robert
Calvin, Robert
Rose, Regal, Calvin, Robert
*/
console.log("Answer for Q5:")
let styles = ["James", "Brennie"];
console.log("Original: ", styles);
styles.push("Robert");
console.log("1. Append \"Robert\": ", styles);
styles[Math.floor((styles.length - 1) / 2)] = "Calvin";
console.log("2. Replace the value in the middle by \"Calvin\": ", styles);
styles.shift();
console.log("3. Remove the first value of the array and show it: ", styles);
styles.unshift("Rose", "Regal");
console.log("4. Prepend Rose and Regal to the array: ", styles);