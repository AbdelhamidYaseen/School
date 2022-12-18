//COMMENT SECTION
let txtarea = document.querySelector('textarea');
let btn = document.querySelector('.btn');
let submit = document.querySelector('#submit')
let comments = document.getElementById('comment-container');
let commentsList = [];

let display_comments = () => {
  let list = '<ul>';
   commentsList.forEach(comment => {
    list += `<li>${comment}</li>`;
  })
  list += '</ul>';
  comments.innerHTML = list;
}

submit.onclick = function(event){
    event.preventDefault();
    let content = txtarea.value;
      commentsList.push(content);
      display_comments();
      txtarea.value = '';
}
//LIKE BUTTON
let likeButton = document.getElementById('like-button');
likeButton.onclick = function(event){
  event.preventDefault();
  if (likeButton.style.color =="red") {
    likeButton.style.color = "black"
    likeButton.style.backgroundColor = "grey"
}
else{
  likeButton.style.color = "red"
  likeButton.style.backgroundColor = "purple"
}

}
