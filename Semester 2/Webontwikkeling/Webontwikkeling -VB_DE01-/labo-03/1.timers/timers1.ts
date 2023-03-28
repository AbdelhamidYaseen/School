console.log('setTimeout! - 1');

const delayInMilliseconds = 1000; // this is one second

console.log('setTimeout! - 2');

const doLater = () => {
  console.log('setTimeout! - 3');
};

console.log('setTimeout! - 4');

setTimeout(doLater, delayInMilliseconds);

console.log('setTimeout! - 5');