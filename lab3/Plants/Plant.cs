namespace lab3;


    public abstract record Plant
    {
        private string _ShortName;
        public string ShortName
        {
            get { return _ShortName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new AggregateException("Введіть шось неможна залишати порожнім");
                _ShortName = value;
            }
        }
        private string _FullName;
        public string FullName
        {
            get { return _FullName; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new AggregateException("Введіть шось неможна залишати порожнім");
                _FullName = value;
            }
        }
        
        private int _GrowingTime;
        public int GrowingTime
        {
            get { return _GrowingTime; }
            set
            {
                if (0 >= value)
                    throw new AggregateException("Введіть шось неможна залишати порожнім");
                _GrowingTime = value;
            }
        }
        
      
        public bool IsNeedRegrow { get; set; }
        public bool IsRipe { get; set; }
        protected Plant(string shortName, string fullName, int growingTime, bool isNeedRegrow, bool isRipe)
        {
            ShortName = shortName;
            FullName = fullName;
            GrowingTime = growingTime;
            IsNeedRegrow = isNeedRegrow;
            IsRipe = isRipe;

        }

        // public Plant setPlant(string shortName, string fullName, int growingTime, bool isNeedRegrow)
        // {
        //     return Plant(shortName, fullName, growingTime, isNeedRegrow);
        // }
        public event EventHandler<PlantGrownEventArgs>? PlantGrown;
        
        internal virtual void OnPlantGrown()
        {
            PlantGrown?.Invoke(this, new PlantGrownEventArgs(this));
        }
        public virtual bool CanHarvest()
        {
            
            return IsRipe;
        }

    } //зробити непераджувану рослину