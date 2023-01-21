  public class Mapper<TSource, TDestination> where TSource : new() where TDestination : new()
    {
        public MapperConfiguration config { get; }

        public Mapper()
        {
            config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TSource, TDestination>()
                  .ReverseMap();
            });
        }
        public ICollection<TSource> ToSource(ICollection<TDestination> source)
        {
            if (source == null) throw new ArgumentException(nameof(source));
           
            return config.CreateMapper().Map<ICollection<TSource>>(source);
        }

        public ICollection<TDestination> ToDestination(ICollection<TSource> destination)
        {
            if (destination == null) throw new ArgumentException(nameof(destination));

            return config.CreateMapper().Map<ICollection<TDestination>>(destination);
        }

        public TSource ToSource(TDestination destination) 
        {
            if (destination == null) throw new ArgumentException(nameof(destination));

            return config.CreateMapper().Map<TSource>(destination);
        }

        public TDestination ToDestination(TSource source)
        {
            if (source == null) throw new ArgumentException(nameof(source));

            return config.CreateMapper().Map<TDestination>(source);
        }
    }
