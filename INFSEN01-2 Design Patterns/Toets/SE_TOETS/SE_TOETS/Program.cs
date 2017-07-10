using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SE_TOETS {

    public interface IMoveableObject {
        float GetPosition();
        void Move(float speed);
    }
    public class SpaceShip : IMoveableObject {
        private float position;
        public float GetPosition() { return position; }
        public SpaceShip() { position = 0.0f; }
        public void Move(float speed) {
            this.position = this.position + speed;
        }
    }
    public abstract class SpaceShipDecorator : IMoveableObject {
        protected IMoveableObject space_ship;
        public SpaceShipDecorator(IMoveableObject space_ship) {
            this.space_ship = space_ship;
        }
        public float GetPosition() { return space_ship.GetPosition(); }
        public abstract void Move(float speed);
    }
    public class TurboShip : SpaceShipDecorator {
        public TurboShip(IMoveableObject space_ship) : base(space_ship) { }
        public override void Move(float speed) {
            this.space_ship.Move(speed * 10);
        }
    }
    class Program {
        static void Main(string[] args) {
            IMoveableObject space_ship = new SpaceShip();
            IMoveableObject turbo_ship = new TurboShip(space_ship);
            turbo_ship.Move(1.0f);
            Console.WriteLine(space_ship.GetPosition());

            Console.Read();
        }
    }
}
