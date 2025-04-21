function handleOnLoad(){
    populateList();
}


function handleOnChange(){
    const selectedID = document.getElementById("selectListBox").value;
    console.log('the id is ', selectedID)
    console.log('this is the list of characters', charList)
    charList.forEach((char) => {
        if (char.jediId == selectedID) {
            myChar = char;
        }
    });
    populateForm();
}




function populateForm(){
    console.log(myChar)
    // document.getElementById("jediId").value =myChar.jediId;
    document.getElementById("name").value =myChar.name;
    document.getElementById("lightsaberColor").value =myChar.lightsaberColor;
    document.getElementById("home").value =myChar.home;
    document.getElementById("born").value =myChar.born;
    document.getElementById("gender").value =myChar.gender;
    document.getElementById("rank").value =myChar.rank;
    document.getElementById("nickname").value =myChar.nickname;
    document.getElementById("master").value =myChar.master;
    document.getElementById("padawan").value =myChar.padawan;
    document.getElementById("characterCover").value =myChar.characterURL;
    var html = "<img class = \"coverArt\" src = \""+myChar.characterURL+"\"></img>";
    document.getElementById("picBox").innerHTML = html;
}

function hideButtons(){
    document.getElementById("newButton").style.display = "none";
    document.getElementById("editButton").style.display = "none";
    document.getElementById("deleteButton").style.display = "none";

}

function showButtons(){
    document.getElementById("newButton").style.display = "inline-block";
    document.getElementById("editButton").style.display = "inline-block";
    document.getElementById("deleteButton").style.display = "inline-block";
}

function makeEditable(){
    document.getElementById("jeidiId").readOnly = false;
    document.getElementById("name").readOnly = false;
    document.getElementById("lightsaberColor").readOnly = false;
    document.getElementById("home").readOnly = false;
    document.getElementById("born").readOnly = false;
    document.getElementById("gender").readOnly = false;
    document.getElementById("rank").readOnly = false;
    document.getElementById("nickname").readOnly = false;
    document.getElementById("master").readOnly = false;
    document.getElementById("padawan").readOnly = false;
    document.getElementById("characterURL").readOnly = false;
}

function blankFields(){
    document.getElementById("jediId").value ="";
    document.getElementById("name").value ="";
    document.getElementById("lightsaberColor").value ="";
    document.getElementById("home").value ="";
    document.getElementById("born").value ="";
    document.getElementById("gender").value ="";
    document.getElementById("rank").value ="";
    document.getElementById("nickname").value ="";
    document.getElementById("master").value ="";
    document.getElementById("padawan").value ="";
    document.getElementById("characterURL").value ="";
}

function makeReadOnly(){
    document.getElementById("jediId").readOnly = true;
    document.getElementById("name").readOnly = true;
    document.getElementById("lightsaberColor").readOnly = true;
    document.getElementById("home").readOnly = true;
    document.getElementById("born").readOnly = true;
    document.getElementById("gender").readOnly = true;
    document.getElementById("rank").readOnly = true;
    document.getElementById("nickname").readOnly = true;
    document.getElementById("master").readOnly = true;
    document.getElementById("padawan").readOnly = true;
    document.getElementById("characterURL").readOnly = true;
}