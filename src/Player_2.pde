//Kirubashini S

DotObject dot;

void setup() {
size(500,500);
dot = new DotObject();
}

void draw() {
  background (255);
  if(dot != null){
  dot.Display();
  dot.Move();
}
}

void mouseClicked() {
if(dot !=null){
  if( mouseX >= dot.x && mouseX >= dot.x + 20 &&
     mouseY >= dot.y && mouseY >= dot.y + 20 ) {
       
     }  dot = null;
     }
}
