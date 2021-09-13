# Health Point System Architecure

We make system with next requirments


- Entities have `HP`
- You can be damages
- You can be regenerated
- You can die(if you're helath is below 0)

``` puml
@startuml


interface IAlive
interface IDamagable
abstract class  AliveUnit 
abstract class Vehical
interface IComperable 

class Player
class Enemy
class Car
class Panzer
class Helicopter
class Environment
class Tree
class Gun

IDamagable o-- Gun
Gun  o-- Panzer 

Gun o-- Player
IAlive <|-- AliveUnit
IDamagable <|-- IAlive
AliveUnit <|-- Player
AliveUnit <|-- Enemy

IAlive <|-- Vehical
IComperable <|-- Vehical
IDamagable <|-- Environment

Vehical <|-- Panzer
Vehical <|-- Helicopter
Vehical <|-- Car
Environment <|-- Tree



interface IAlive {
    
    event Action OnDiead;
    event Action OnDamage;

    int HP {get;} 
    
}
interface IDamagable{

    void TakeDamage(int damage, Vector3 pointOfDamage);
}
abstract class  AliveUnit {

    int HP {get;private set;} 

    void Regenarate();
    void TakeDamage(int damage, Vector3 pointOfDamage)
    if(HP-damage<0) {HP=0; 
        OnDied?.Invoke(); 

}
abstract class  Vehical {

    int HP {get;private set;} 
    void Repair();
    abstract void Move();
    public virtual int CompareTo(object? obj);
}
class Environment{
    HP=>1
}

class Player{
    pviate int _damage = 5;
    pivate Gun _gun;
}

class Enemy{
    public Enenmy{ OnTakeDamage+=Move; }
}


class Gun{
  void Attack(IDamagable target){target.TakeDamage(_damage)}

}
class Panzer{

    public override int CompareTo(object? obj)


}
@enduml
```