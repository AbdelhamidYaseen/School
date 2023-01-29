let email : string = "yaseen.abdelhamid@gmail.com";

console.log(`${email.substring(0,email.indexOf(".")).toUpperCase()} ${email.substring(email.indexOf(".")+1,email.indexOf("@")).toUpperCase()}`);