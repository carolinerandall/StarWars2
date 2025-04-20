using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace codingchallenge
{
    public class Jedi
    {
        private int JediID;
        private string name;

        private string lightsaberColor;
        private string species;
        private string homeworld;

        public Jedi(){

        }
        public Jedi(int JediID, string name, string lightsaberColor, string species, string homeworld){
            this.JediID=JediID;
            this.name=name;
            this.lightsaberColor=lightsaberColor;
            this.species=species;
            this.homeworld=homeworld;
        }
        public int GetJediID(){
            return JediID;
        }
        public void SetJediID(int JediID){
            this.JediID=JediID;
        }
        public string GetName(){
            return name;
        }
        public void SetName(string name){
            this.name=name;
        }
        public string GetLightsaberColor(){
            return lightsaberColor;
        }
        public void SetLightsaberColor(string lightsaberColor){
            this.lightsaberColor=lightsaberColor;
        }
        public string GetSpecies(){
            return species;
        }
        public void SetSpecies(string species){
            this.species=species;
        }
        public string GetHomeworld(){
            return homeworld;
        }
        public void SetHomeworld(string homeworld){
            this.homeworld=homeworld;
        }


    }
}