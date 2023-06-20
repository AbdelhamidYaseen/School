# Date

JavaScript Date objects represent a single moment in time in a platform-independent format. Date objects encapsulate an integral number that represents milliseconds since the midnight at the beginning of January 1, 1970, UTC (the epoch).

## The epoch, timestamps, and invalid date

A JavaScript date is fundamentally specified as the time in milliseconds that has elapsed since the epoch, which is defined as the midnight at the beginning of January 1, 1970, UTC (equivalent to the UNIX epoch). This timestamp is timezone-agnostic and uniquely defines an instant in history.

A date is represented internally as a single number, the timestamp. When interacting with it, the timestamp needs to be interpreted as a structured date-and-time representation. There are always two ways to interpret a timestamp: as a local time or as a Coordinated Universal Time (UTC), the global standard time defined by the World Time Standard. The local timezone is not stored in the date object, but is determined by the host environment (user's device).

There are two groups of Date methods: one group gets and sets various date components by interpreting the timestamp as a local time, while the other uses UTC.
Component| 	Local | |	UTC | |
|---|---|---|---|---|
| | Get |	Set |	Get |	Set
Year |	getFullYear() |	setFullYear() |	getUTCFullYear() |	setUTCFullYear()
Month |	getMonth() |	setMonth() |	getUTCMonth() |	setUTCMonth()
Date (of month) |	getDate() |	setDate() |	getUTCDate() |	setUTCDate()
Hours |	getHours() |	setHours() |	getUTCHours() |	setUTCHours()
Minutes |	getMinutes() |	setMinutes() |	getUTCMinutes() |	setUTCMinutes()
Seconds |	getSeconds() |	setSeconds() |	getUTCSeconds() |	setUTCSeconds()
Milliseconds |	getMilliseconds() |	setMilliseconds() |	getUTCMilliseconds() |	setUTCMilliseconds()
Day (of week) |	getDay() |	N/A |	getUTCDay() |	N/A

The Date() constructor can be called with two or more arguments, in which case they are interpreted as the year, month, day, hour, minute, second, and millisecond, respectively, in local time. Date.UTC() works similarly, but it interprets the components as UTC time and also accepts a single argument representing the year.

## Date time string format

There are many ways to format a date as a string. The JavaScript specification only specifies one format to be universally supported: the date time string format, a simplification of the ISO 8601 calendar date extended format. The format is as follows:

`YYYY-MM-DDTHH:mm:ss.sssZ`

- YYYY is the year, with four digits (0000 to 9999), or as an expanded year of + or - followed by six digits. The sign is required for expanded years. -000000 is explicitly disallowed as a valid year.
- MM is the month, with two digits (01 to 12). Defaults to 01.
- DD is the day of the month, with two digits (01 to 31). Defaults to 01.
- T is a literal character, which indicates the beginning of the time part of the string. The T is required when specifying the time part.
- HH is the hour, with two digits (00 to 23). As a special case, 24:00:00 is allowed, and is interpreted as midnight at the beginning of the next day. Defaults to 00.
- mm is the minute, with two digits (00 to 59). Defaults to 00.
- ss is the second, with two digits (00 to 59). Defaults to 00.
- sss is the millisecond, with three digits (000 to 999). Defaults to 000.
- Z is the timezone offset, which can either be the literal character Z (indicating UTC), or + or - followed by HH:mm, the offset in hours and minutes from UTC.

Various components can be omitted, so the following are all valid:

- Date-only form: YYYY, YYYY-MM, YYYY-MM-DD
- Date-time form: one of the above date-only forms, followed by T, followed by HH:mm, HH:mm:ss, or HH:mm:ss.sss. Each combination can be followed by a time zone offset.

Date.parse() and the Date() constructor both accept strings in the date time string format as input. 

### Constructor

> #### `Date()`
> #### `Date(dateTimeString : string)`
> 
> When called as a constructor, returns a new Date object. When called as a function, returns a string representation of the current date and time.

### Instance methods

> #### `getTime()`
> 
> Returns the numeric value of the specified date as the number of milliseconds since January 1, 1970, 00:00:00 UTC. (Negative values are returned for prior times.)

> #### `getDate()`
> 
> Returns the day of the month (1 – 31) for the specified date according to local time.

> #### `getDay()`
> 
> Returns the day of the week (0 – 6) for the specified date according to local time.

> #### `getFullYear()`
> 
> Returns the year (4 digits for 4-digit years) of the specified date according to local time.

> #### `getHours()`
> 
> Returns the hour (0 – 23) in the specified date according to local time.

> #### `getMilliseconds()`
> 
> Returns the milliseconds (0 – 999) in the specified date according to local time.

> #### `getMinutes()`
> 
> Returns the minutes (0 – 59) in the specified date according to local time.

> #### `getMonth()`
> 
> Returns the month (0 – 11) in the specified date according to local time.

> #### `getSeconds()`
> 
> Returns the seconds (0 – 59) in the specified date according to local time.

> #### `getTimezoneOffset()`
> 
> Returns the time-zone offset in minutes for the current locale.

> #### `getUTCDate()`
> 
> Returns the day (date) of the month (1 – 31) in the specified date according to universal time.

> #### `getUTCDay()`
> 
> Returns the day of the week (0 – 6) in the specified date according to universal time.

> #### `getUTCFullYear()`
> 
> Returns the year (4 digits for 4-digit years) in the specified date according to universal time.

> #### `getUTCHours()`
> 
> Returns the hours (0 – 23) in the specified date according to universal time.

> #### `getUTCMilliseconds()`
> 
> Returns the milliseconds (0 – 999) in the specified date according to universal time.

> #### `getUTCMinutes()`
> 
> Returns the minutes (0 – 59) in the specified date according to universal time.

> #### `getUTCMonth()`
> 
> Returns the month (0 – 11) in the specified date according to universal time.

> #### `getUTCSeconds()`
> 
> Returns the seconds (0 – 59) in the specified date according to universal time.

> #### `setDate()`
> 
> Sets the day of the month for a specified date according to local time.

> #### `setFullYear()`
> 
> Sets the full year (e.g. 4 digits for 4-digit years) for a specified date according to local time.

> #### `setHours()`
> 
> Sets the hours for a specified date according to local time.

> #### `setMilliseconds()`
> 
> Sets the milliseconds for a specified date according to local time.

> #### `setMinutes()`
> 
> Sets the minutes for a specified date according to local time.

> #### `setMonth()`
> 
> Sets the month for a specified date according to local time.

> #### `setSeconds()`
> 
> Sets the seconds for a specified date according to local time.

> #### `setTime()`
> 
> Sets the Date object to the time represented by a number of milliseconds since January 1, 1970, 00:00:00 UTC. Use negative numbers for times prior.

> #### `setUTCDate()`
> 
> Sets the day of the month for a specified date according to universal time.

> #### `setUTCFullYear()`
> 
> Sets the full year (e.g. 4 digits for 4-digit years) for a specified date according to universal time.

> #### `setUTCHours()`
> 
> Sets the hour for a specified date according to universal time.

> #### `setUTCMilliseconds()`
> 
> Sets the milliseconds for a specified date according to universal time.

> #### `setUTCMinutes()`
> 
> Sets the minutes for a specified date according to universal time.

> #### `setUTCMonth()`
> 
> Sets the month for a specified date according to universal time.

> #### `setUTCSeconds()`
> 
> Sets the seconds for a specified date according to universal time.

> #### `toDateString()`
> 
> Returns the "date" portion of the Date as a human-readable string like 'Thu Apr 12 2018'.

> #### `toISOString()`
> 
> Converts a date to a string following the ISO 8601 Extended Format.

> #### `toJSON()`
> 
> Returns a string representing the Date using toISOString(). Intended for use by JSON.stringify().

> #### `toLocaleDateString()`
> 
> Returns a string with a locality sensitive representation of the date portion of this date based on system settings.

> #### `toLocaleString()`
> 
> Returns a string with a locality-sensitive representation of this date. Overrides the Object.prototype.toLocaleString() method.

> #### `toLocaleTimeString()`
> 
> Returns a string with a locality-sensitive representation of the time portion of this date, based on system settings.

> #### `toString()`
> 
> Returns a string representing the specified Date object. Overrides the Object.prototype.toString() method.

> #### `toTimeString()`
> 
> Returns the "time" portion of the Date as a human-readable string.

> #### `toUTCString()`
> 
> Converts a date to a string using the UTC timezone.

> #### `valueOf()`
> 
> Returns the primitive value of a Date object. Overrides the Object.prototype.valueOf() method.

### Static methods


> #### `Date.now()`
>
> Returns the numeric value corresponding to the current time—the number of milliseconds elapsed since January 1, 1970 00:00:00 UTC, with leap seconds ignored.

> #### `Date.parse()`
>
> Parses a string representation of a date and returns the number of milliseconds since 1 January, 1970, 00:00:00 UTC, with leap seconds ignored.

> #### `Date.UTC()`
>
> Accepts the same parameters as the longest form of the constructor (i.e. 2 to 7) and returns the number of milliseconds since January 1, 1970, 00:00:00 UTC, with leap seconds ignored.