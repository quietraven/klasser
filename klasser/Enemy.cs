class Enemy
{
    

    public List<string> names = ["Jeff", ""];
    public string Name;
    public int Hp;

    private int _maxDamage = 30; // private kan bara användas i metoder inuti samma klass

    public Enemy()
    {
        int i = Random.Shared.Next(names.Count);
    }

    public int Attack()
    {
        return Random.Shared.Next(5, _maxDamage);
    }
}