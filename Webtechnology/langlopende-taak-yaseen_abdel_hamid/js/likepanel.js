//COMMENT SECTION
let txtarea = document.querySelector('textarea');
let submitBtn = document.querySelector('#submit')
let commentSection = document.getElementById('comment-container');
let commentsList = [];

let display_comments = () => {
  let listComments = '<ul>';
   commentsList.forEach(comment => {
    listComments += `<li>${comment}</li>`;
  })
  listComments += '</ul>';
  commentSection.innerHTML = listComments;
}

submitBtn.onclick = function(event){
    event.preventDefault();
    let content = txtarea.value;
    if(content.length < 3){
      alert("Minimum comment length: 3")
      return
    }
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
