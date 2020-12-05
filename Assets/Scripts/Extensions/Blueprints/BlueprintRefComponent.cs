namespace Common.Extensions.Blueprints
{
    internal struct BlueprintRefComponent<T>
        where T : Blueprint
    {
        public T Value;
    }
}