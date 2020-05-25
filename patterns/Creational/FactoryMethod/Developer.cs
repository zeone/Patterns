namespace patterns.Creational.FactoryMethod
{
    /// <summary>
    /// Если логика создания обьекта сложная, либо требует выполнения доп операций, а использовать конструктор не лучшая идея,
    /// то используеться данный паттерн
    /// </summary>
    public abstract class Developer
    {
        public string Name { get; set; }

        public Developer(string n)
        {
            Name = n;
        }
        // фабричный метод
        public abstract House Create();
    }
}
