//Paul Tokhtuev
class DotObject {
  int x,y;
  
  DotObject()
  {
    x = int(random(width));
    y = int(random(width));
  }
  
  void Display(){
   rect(x,y,5,5); 
  }
  void Move(){
    if(key == 'w'||key =='W'){ y -=5; }
    else if(key == 'd'||key =='D'){ x +=5; }
    else if(key == 'S'||key =='s'){ y +=5; }
    else if(key == 'a'||key =='A'){ x -=5; }
  }
  
  
}
