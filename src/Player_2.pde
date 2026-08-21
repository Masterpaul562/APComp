//Kirubashini S

DotObject dot;

void setup() {
size(500,500);
dot = new DotObject();
}

void draw() {
  background (255);
  
  dot.Display();
  dot.Move();

}

void mouseClicked() {
  if( mouseX >= dot.x && mouseX >= dot.x + 20 &&
     mouseY >= dot.y && mouseY >= dot.y + 20 ) {
       
     }  dot = null;
     
}
