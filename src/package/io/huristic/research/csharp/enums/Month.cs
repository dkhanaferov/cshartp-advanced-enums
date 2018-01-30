namespace Io.huristic.research.csharp.enums
{
    public struct Month {

        public static readonly Month January =   new Month("January", 1, "Winter");
        public static readonly Month February =  new Month("February", 2, "Winter");
        public static readonly Month March =     new Month("March", 3, "Spring");
        public static readonly Month April =     new Month("April", 4, "Spring");
        public static readonly Month May =       new Month("May", 5, "Spring");
        public static readonly Month June =      new Month("June", 6, "Summer");
        public static readonly Month July =      new Month("July", 7, "Summer");
        public static readonly Month August =    new Month("August", 8, "Summer");
        public static readonly Month September = new Month("September", 9, "Autumn");
        public static readonly Month October =   new Month("October", 10, "Autumn");
        public static readonly Month November =  new Month("November", 11, "Autumn");
        public static readonly Month December =  new Month("December", 12, "Winter");
                
        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <value>The name.</value>
        public string Name {get; private set;}

        /// <summary>
        /// Gets the index.
        /// </summary>
        /// <value>The index.</value>
        public short Index {get; private set;}

        /// <summary>
        /// Gets the season.
        /// </summary>
        /// <value>The season.</value>
        public string Season {get; private set;}

        /// <summary>
        /// Gets a value indicating whether this <see cref="T:Io.huristic.research.csharp.enums.Month"/> is default.
        /// </summary>
        /// <value><c>true</c> if is default; otherwise, <c>false</c>.</value>
        public bool IsDefault => Name == default(string) && Index == default(int) && Season == default(string);

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Io.huristic.research.csharp.enums.Month"/> struct.
        /// </summary>
        /// <param name="name">Name.</param>
        /// <param name="index">Index.</param>
        /// <param name="season">Season.</param>
        private Month(string name, short index, string season) {
            Name = name;
            Index = index;
            Season = season;
        }

        /// <summary>
        /// Determines whether the specified <see cref="Io.huristic.research.csharp.enums.Month"/> is equal to the
        /// current <see cref="T:Io.huristic.research.csharp.enums.Month"/>.
        /// </summary>
        /// <param name="other">The <see cref="Io.huristic.research.csharp.enums.Month"/> to compare with the current <see cref="T:Io.huristic.research.csharp.enums.Month"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="Io.huristic.research.csharp.enums.Month"/> is equal to the current
        /// <see cref="T:Io.huristic.research.csharp.enums.Month"/>; otherwise, <c>false</c>.</returns>
        private bool Equals(Month other)
		{
			return string.Equals(Name, other.Name) && string.Equals(Season, other.Season) && Index == other.Index;
		}

        /// <summary>
        /// Determines whether the specified <see cref="object"/> is equal to the current <see cref="T:Io.huristic.research.csharp.enums.Month"/>.
        /// </summary>
        /// <param name="obj">The <see cref="object"/> to compare with the current <see cref="T:Io.huristic.research.csharp.enums.Month"/>.</param>
        /// <returns><c>true</c> if the specified <see cref="object"/> is equal to the current
        /// <see cref="T:Io.huristic.research.csharp.enums.Month"/>; otherwise, <c>false</c>.</returns>
        public override bool Equals(object obj)
		{
			if (ReferenceEquals(null, obj)) return false;
			if (ReferenceEquals(this, obj)) return true;
			if (obj.GetType() != this.GetType()) return false;
			return Equals((Month) obj);
		}

        /// <summary>
        /// Serves as a hash function for a <see cref="T:Io.huristic.research.csharp.enums.Month"/> object.
        /// </summary>
        /// <returns>A hash code for this instance that is suitable for use in hashing algorithms and data structures such as a
        /// hash table.</returns>
        public override int GetHashCode()
		{
			unchecked
			{
				var hashCode = ((Name != null ? Name.GetHashCode() : 0) * 397);
                hashCode = (hashCode * 397) ^ Index;
                hashCode = (hashCode * 397) ^ (Season != null ? Season.GetHashCode() : 0);
                return hashCode;
			}
		}

        /// <summary>
        /// Determines whether a specified instance of <see cref="Io.huristic.research.csharp.enums.Month"/> is equal to
        /// another specified <see cref="Io.huristic.research.csharp.enums.Month"/>.
        /// </summary>
        /// <param name="left">The first <see cref="Io.huristic.research.csharp.enums.Month"/> to compare.</param>
        /// <param name="right">The second <see cref="Io.huristic.research.csharp.enums.Month"/> to compare.</param>
        /// <returns><c>true</c> if <c>left</c> and <c>right</c> are equal; otherwise, <c>false</c>.</returns>
        public static bool operator ==(Month left, Month right)
		{
			return Equals(left, right);
		}

        /// <summary>
        /// Determines whether a specified instance of <see cref="Io.huristic.research.csharp.enums.Month"/> is not
        /// equal to another specified <see cref="Io.huristic.research.csharp.enums.Month"/>.
        /// </summary>
        /// <param name="left">The first <see cref="Io.huristic.research.csharp.enums.Month"/> to compare.</param>
        /// <param name="right">The second <see cref="Io.huristic.research.csharp.enums.Month"/> to compare.</param>
        /// <returns><c>true</c> if <c>left</c> and <c>right</c> are not equal; otherwise, <c>false</c>.</returns>
		public static bool operator !=(Month left, Month right)
		{
			return !Equals(left, right);
		}

        /// <summary>
        /// Determines whether one specified <see cref="Io.huristic.research.csharp.enums.Month"/> is greater than
        /// another specfied <see cref="Io.huristic.research.csharp.enums.Month"/>.
        /// </summary>
        /// <param name="left">The first <see cref="Io.huristic.research.csharp.enums.Month"/> to compare.</param>
        /// <param name="right">The second <see cref="Io.huristic.research.csharp.enums.Month"/> to compare.</param>
        /// <returns><c>true</c> if <c>left</c> is greater than <c>right</c>; otherwise, <c>false</c>.</returns>
        public static bool operator >(Month left, Month right)
		{
			return left.Index > right.Index;
		}

        /// <summary>
        /// Determines whether one specified <see cref="Io.huristic.research.csharp.enums.Month"/> is lower than another
        /// specfied <see cref="Io.huristic.research.csharp.enums.Month"/>.
        /// </summary>
        /// <param name="left">The first <see cref="Io.huristic.research.csharp.enums.Month"/> to compare.</param>
        /// <param name="right">The second <see cref="Io.huristic.research.csharp.enums.Month"/> to compare.</param>
        /// <returns><c>true</c> if <c>left</c> is lower than <c>right</c>; otherwise, <c>false</c>.</returns>
        public static bool operator <(Month left, Month right)
		{
			return left.Index < right.Index;
		}

        /// <summary>
        /// Determines whether one specified <see cref="Io.huristic.research.csharp.enums.Month"/> is greater than or
        /// equal to another specfied <see cref="Io.huristic.research.csharp.enums.Month"/>.
        /// </summary>
        /// <param name="left">The first <see cref="Io.huristic.research.csharp.enums.Month"/> to compare.</param>
        /// <param name="right">The second <see cref="Io.huristic.research.csharp.enums.Month"/> to compare.</param>
        /// <returns><c>true</c> if <c>left</c> is greater than or equal to <c>right</c>; otherwise, <c>false</c>.</returns>
        public static bool operator >=(Month left, Month right)
		{
			return left.Index >= right.Index;
		}

        /// <summary>
        /// Determines whether one specified <see cref="Io.huristic.research.csharp.enums.Month"/> is lower than or
        /// equal to another specfied <see cref="Io.huristic.research.csharp.enums.Month"/>.
        /// </summary>
        /// <param name="left">The first <see cref="Io.huristic.research.csharp.enums.Month"/> to compare.</param>
        /// <param name="right">The second <see cref="Io.huristic.research.csharp.enums.Month"/> to compare.</param>
        /// <returns><c>true</c> if <c>left</c> is lower than or equal to <c>right</c>; otherwise, <c>false</c>.</returns>
        public static bool operator <=(Month left, Month right)
		{
			return left.Index <= right.Index;
		}
    }
}