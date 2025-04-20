const cwid = "12295992"; //please update with your cwid
const baseUrl = "http://localhost:5240/api/character";
var charList = [];
var myChar = {};

async function populateList(){

    const allCharApiUrl = baseUrl;
    let response = await fetch(allCharApiUrl);
    let json = await response.json();

    let html = "<select class = \"listBox\" onchange = \"handleOnChange()\" id= \"selectListBox\" name = \"list_box\" size=5 width=\"100%\">";
    json.forEach((char)=>{
        html += "<option value = " + char.jediId  + ">" + char.name + "</option>";
     })
        html += "</select>";
    document.getElementById("listBox").innerHTML = html;

}

function putBook(id){
    const putBookApiUrl = baseUrl + "/"+id;
    const sendBook = {
        id: id,
        title: document.getElementById("bookTitle").value,
        author: document.getElementById("bookAuthor").value,
        genre: document.getElementById("bookGenre").value,
        numAvlb: parseInt(document.getElementById("bookAvlb").value),
        isbn: document.getElementById("bookIsbn").value,
        length: parseInt(document.getElementById("bookLength").value),
        cover: document.getElementById("bookCover").value
    }
    fetch(putBookApiUrl, {
        method: "PUT",
        headers: {
            "Accept": 'application/json',
            "Content-Type": 'application/json',
        },
        body: JSON.stringify(sendBook)
    })
    .then((response)=>{
        myBook = sendBook;
        populateList();
        populateForm();
    });
}

function postBook(){
    const postBookApiUrl = baseUrl;
    const sendBook = {
        title: document.getElementById("bookTitle").value,
        author: document.getElementById("bookAuthor").value,
        genre: document.getElementById("bookGenre").value,
        numAvlb: parseInt(document.getElementById("bookAvlb").value),
        isbn: document.getElementById("bookIsbn").value,
        length: parseInt(document.getElementById("bookLength").value),
        cover: document.getElementById("bookCover").value
    }
    fetch(postBookApiUrl, {
        method: "POST",
        headers: {
            "Accept": 'application/json',
            "Content-Type": 'application/json',
        },
        body: JSON.stringify(sendBook)
    })
    .then((response)=>{
        myBook = sendBook;
        populateList();
        blankFields();
    });
}

function deleteBook(){
    const deleteBookApiUrl = baseUrl + "/" + myBook.id;
    fetch(deleteBookApiUrl, {
        method: "DELETE",
        headers: {
            "Accept": 'application/json',
            "Content-Type": 'application/json',
        }
    })
    .then((response)=>{
        blankFields();
        populateList();
    });
}