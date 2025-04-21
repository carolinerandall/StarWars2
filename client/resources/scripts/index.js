function handleOnLoad(){
    populateList();
}


function handleOnChange(){
    const selectedID = document.getElementById("selectListBox").value;
    charList.forEach((char) => {
        if (char.id == selectedID) {
            myChar = char;
        }
    });
    populateForm();
}




function populateForm(){
    document.GetElementById("jediId").value =myChar.jediId;
    document.GetElementById("name").value =myChar.name;
    document.GetElementById("lightsaberColor").value =myChar.lightsaberColor;
    document.GetElementById("home").value =myChar.home;
    document.GetElementById("born").value =myChar.born;
    document.GetElementById("gender").value =myChar.gender;
    document.GetElementById("rank").value =myChar.rank;
    document.GetElementById("nickname").value =myChar.nickname;
    document.GetElementById("master").value =myChar.master;
    document.GetElementById("padawan").value =myChar.padawan;
    document.GetElementById("characterURL").value =myChar.characterURL;
    var html = "<img class = \"coverArt\" src = \""+myChar.characterURL+"\"></img>";
    document.getElementById("picBox").innerHTML = html;
}

function hideButtons(){
    document.GetElementById("newButton").style.display = "none";
    document.GetElementById("editButton").style.display = "none";
    document.GetElementById("deleteButton").style.display = "none";

}

function showButtons(){
    document.GetElementById("newButton").style.display = "inline-block";
    document.GetElementById("editButton").style.display = "inline-block";
    document.GetElementById("deleteButton").style.display = "inline-block";
}

function makeEditable(){
    document.GetElementById("jeidiId").readOnly = false;
    document.GetElementById("name").readOnly = false;
    document.GetElementById("lightsaberColor").readOnly = false;
    document.GetElementById("home").readOnly = false;
    document.GetElementById("born").readOnly = false;
    document.GetElementById("gender").readOnly = false;
    document.GetElementById("rank").readOnly = false;
    document.GetElementById("nickname").readOnly = false;
    document.GetElementById("master").readOnly = false;
    document.GetElementById("padawan").readOnly = false;
    document.GetElementById("characterURL").readOnly = false;
}

function blankFields(){
    document.GetElementById("jediId").value ="";
    document.GetElementById("name").value ="";
    document.GetElementById("lightsaberColor").value ="";
    document.GetElementById("home").value ="";
    document.GetElementById("born").value ="";
    document.GetElementById("gender").value ="";
    document.GetElementById("rank").value ="";
    document.GetElementById("nickname").value ="";
    document.GetElementById("master").value ="";
    document.GetElementById("padawan").value ="";
    document.GetElementById("characterURL").value ="";
}

function makeReadOnly(){
    document.GetElementById("jediId").readOnly = true;
    document.GetElementById("name").readOnly = true;
    document.GetElementById("lightsaberColor").readOnly = true;
    document.GetElementById("home").readOnly = true;
    document.GetElementById("born").readOnly = true;
    document.GetElementById("gender").readOnly = true;
    document.GetElementById("rank").readOnly = true;
    document.GetElementById("nickname").readOnly = true;
    document.GetElementById("master").readOnly = true;
    document.GetElementById("padawan").readOnly = true;
    document.GetElementById("characterURL").readOnly = true;
}