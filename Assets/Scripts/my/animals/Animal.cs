namespace Assets.Scripts.my.animals
{
    using Assets.Scripts.my.terrain;
    using Assets.Scripts.my.movement;
    using System.Collections.Generic;

    public class Animal{
        public string name { get; protected set; }  
        private List<Locomotion> locomotionTypes;
    }
}