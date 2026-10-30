# Final Project Plan - Foundation 4

## Program 1 - Abstraction with Youtube Videos

The program will store keep track comments on a youtube video, as well as the information of the video itself (such as lenght, title, author, etc). 

### comment
- track name of person
- track content of comment

> _name : string
> _comment : string

GetName()

GetCommentText()

Comment(name, text)

### video
- track: title, author, length(s)
- store comments<list>

> _title : string
> author : string
> length : int
> comments<list>

Video(title, author, length)

DisplayVideo()

* also probably a way to add comments to the list, somewhere


## Program 2: Encapsulation with Online Ordering

The program should be able to create a packing and shipping label for a customer's online order, as well as the price of the order. The classes should have private member variables and appropriate getters, setters, and constructors. 

### Address

(private)
- _street : string
- _city : string
- _state : string
- _country : string

Address(info to construct)

boolean IsInAmerica

some way to get full address

### customer

- name : string
- address : (...object? instance?)

Customer(constructor)

calls address boolean for being USA or not

### product

- name : string
- id : string
- priceperunit : double
- quant : int

getcost, would be priceperunit * quant

### order

-list of products, and customer. 
- calls getcost and adds a shipping cost
-- checks shipping cost against address bool
- packinglabel, return name and id of products from list
- shipping label, returns name and address of customer

## Program 3: Inheritance with Event Planning

The program should have a base class that creates a template/blueprint of sorts that then has derived classes for the individual events. The base class should properly hold the shared attributes and methods to avoid duplication across the derived classes. 

### base class: Event

- title : string
- description : string
- date : datetime or stirng
- time : string probably
- address : string

construct: 
event,
std details - title description date time addy
full details - std details plus sub class specifics
short - event type, title, date


#### lectures
- speaker : string
- capacity : int


#### receptions
- rsvp : bool or string


#### outdoor
- weather : string


each subclass also needs to construct itself

## Program 4: Polymorphism with Exercise Tracking

The base class should have derived classes for specific fitness activities, as well as virtual methods that are then overidden by said derived classes. The program should apply all prior principles as well as have a way to summarize the information contained inside the program. 

### base class Actiity
- date : string
- length (m) : int

virtual or abstract..?:
distance
speed (mph)
pace (min/mi)
summary, using mi OR km


#### run
- distance : double?




#### bike
- speed : double?


#### swim
- laps : int?
(1 lap = 50 m)


