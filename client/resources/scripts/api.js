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

function putChar(id){
    const putCharApiUrl = baseUrl + "/"+id;
    const sendChar = {
        JediId: jediId,
        name: document.getElementById("name").value,
        lightsaberColor: document.getElementById("lightsaberColor").value,
        home: document.getElementById("home").value,
        born: document.getElementById("born").value,
        gender: document.getElementById("gender").value,
        rank: document.getElementById("rank").value,
        nickname: document.getElementById("nickname").value,
        master: document.getElementById("master").value,
        padawan: document.getElementById("padawan").value,
        characterURL: document.getElementById("characterURL").value,

    }
    fetch(putCharApiUrl, {
        method: "PUT",
        headers: {
            "Accept": 'application/json',
            "Content-Type": 'application/json',
        },
        body: JSON.stringify(sendBook)
    })
    .then((response)=>{
        myChar = sendChar;
        populateList();
        populateForm();
    });
}

function postChar(){
    const postCharApiUrl = baseUrl;
    const sendChar = {
        name: document.getElementById("name").value,
        lightsaberColor: document.getElementById("lightsaberColor").value,
        home: document.getElementById("home").value,
        born: document.getElementById("born").value,
        gender: document.getElementById("gender").value,
        rank: document.getElementById("rank").value,
        nickname: document.getElementById("nickname").value,
        master: document.getElementById("master").value,
        padawan: document.getElementById("padawan").value,
        characterURL: document.getElementById("characterURL").value,
    }
    fetch(postCharApiUrl, {
        method: "POST",
        headers: {
            "Accept": 'application/json',
            "Content-Type": 'application/json',
        },
        body: JSON.stringify(sendChar)
    })
    .then((response)=>{
        myChar = sendChar;
        populateList();
        blankFields();
    });
}

function deleteChar(){
    const deleteCharApiUrl = baseUrl + "/" + myChar.id;
    fetch(deleteCharApiUrl, {
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