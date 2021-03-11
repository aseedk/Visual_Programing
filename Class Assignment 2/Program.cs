using System;

namespace Class_Assignment_2
{
    /// <summary>
    /// ACTIVITY 1 STARTS
    /// </summary>
    class Customer
    {
        private long _customerId;
        private string _firstname;
        private string _lastname;
        private string _street;
        private string _city;
        private string _state;
        private string _zipcode;
        private long _phone;
        private string _eMail;
        private string _password;
        private Reservation _reservation;

        public Customer()
        {
            _customerId = 0;
            _firstname = null;
            _lastname = null;
            _street = null;
            _city = null;
            _state = null;
            _zipcode = null;
            _phone = 0;
            _eMail = null;
            _password = null;
            _reservation = null;
        }

        public Customer(long customerId, string firstname, string lastname, string street, string city, string state, string zipcode, long phone, string eMail, string password, Reservation reservation)
        {
            _customerId = customerId;
            this._firstname = firstname;
            this._lastname = lastname;
            this._street = street;
            this._city = city;
            this._state = state;
            this._zipcode = zipcode;
            this._phone = phone;
            this._eMail = eMail;
            this._password = password;
            _reservation = reservation;
        }

        public long CustomerId
        {
            get => _customerId;
            set => _customerId = value;
        }

        public string Firstname
        {
            get => _firstname;
            set => _firstname = value;
        }

        public string Lastname
        {
            get => _lastname;
            set => _lastname = value;
        }

        public string Street
        {
            get => _street;
            set => _street = value;
        }

        public string City
        {
            get => _city;
            set => _city = value;
        }

        public string State
        {
            get => _state;
            set => _state = value;
        }

        public string Zipcode
        {
            get => _zipcode;
            set => _zipcode = value;
        }

        public long Phone
        {
            get => _phone;
            set => _phone = value;
        }

        public string EMail
        {
            get => _eMail;
            set => _eMail = value;
        }

        public string Password
        {
            get => _password;
            set => _password = value;
        }

        public Reservation Reservation
        {
            get => _reservation;
            set => _reservation = value;
        }
    }

    class RetailCustomer: Customer
    {
        private string _creditCardType;
        private long _creditCardNo;

        public RetailCustomer()
        {
            _creditCardType = null;
            _creditCardNo = 0;
        }

        public RetailCustomer(long customerId, string firstname, string lastname, string street, string city, string state, string zipcode, long phone, string eMail, string password, Reservation reservation, string creditCardType, long creditCardNo) : base(customerId, firstname, lastname, street, city, state, zipcode, phone, eMail, password, reservation)
        {
            this._creditCardType = creditCardType;
            this._creditCardNo = creditCardNo;
        }

        public string CreditCardType
        {
            get => _creditCardType;
            set => _creditCardType = value;
        }

        public long CreditCardNo
        {
            get => _creditCardNo;
            set => _creditCardNo = value;
        }
    }

    class CorporateCustomer: Customer
    {
        private string _companyName;
        private int _frequentFlyerPts;
        private long _billingAccountNo;

        public CorporateCustomer()
        {
            _companyName = null;
            _frequentFlyerPts = 0;
            _billingAccountNo = 0;
        }

        public CorporateCustomer(long customerId, string firstname, string lastname, string street, string city, string state, string zipcode, long phone, string eMail, string password, Reservation reservation, string companyName, int frequentFlyerPts, long billingAccountNo) : base(customerId, firstname, lastname, street, city, state, zipcode, phone, eMail, password, reservation)
        {
            this._companyName = companyName;
            this._frequentFlyerPts = frequentFlyerPts;
            this._billingAccountNo = billingAccountNo;
        }

        public string CompanyName
        {
            get => _companyName;
            set => _companyName = value;
        }

        public int FrequentFlyerPts
        {
            get => _frequentFlyerPts;
            set => _frequentFlyerPts = value;
        }

        public long BillingAccountNo
        {
            get => _billingAccountNo;
            set => _billingAccountNo = value;
        }
    }

    class Reservation
    {
        private long _reservationNo;
        private DateTime _date;
        private Seat[] _seats;

        public Reservation()
        {
            _reservationNo = 0;
            _date = new DateTime();
            _seats = null;
        }

        public Reservation(long reservationNo, DateTime date, Seat[] seats)
        {
            this._reservationNo = reservationNo;
            this._date = date;
            _seats = seats;
        }

        public long ReservationNo
        {
            get => _reservationNo;
            set => _reservationNo = value;
        }

        public DateTime Date
        {
            get => _date;
            set => _date = value;
        }

        public Seat[] Seats
        {
            get => _seats;
            set => _seats = value;
        }
    }

    class Seat
    {
        private string _rowNo;
        private int _seatNo;
        private int _price;
        private bool _status;

        public Seat()
        {
            _rowNo = null;
            _seatNo = 0;
            _price = 0;
            _status = false;
        }

        public Seat(string rowNo, int seatNo, int price, bool status)
        {
            this._rowNo = rowNo;
            this._seatNo = seatNo;
            this._price = price;
            this._status = status;
        }

        public string RowNo
        {
            get => _rowNo;
            set => _rowNo = value;
        }

        public int SeatNo
        {
            get => _seatNo;
            set => _seatNo = value;
        }

        public int Price
        {
            get => _price;
            set => _price = value;
        }

        public bool Status
        {
            get => _status;
            set => _status = value;
        }
    }

    class Flight
    {
        private int _flightId;
        private DateTime _date;
        private string _origin;
        private string _destination;
        private DateTime _departureTime;
        private DateTime _arrivalTime;
        private int _seatingCapacity;
        private Seat[] _seats;

        public Flight()
        {
            _flightId = 0;
            _date = new DateTime();
            _origin = null;
            _destination = null;
            _departureTime = new DateTime();
            _arrivalTime = new DateTime();
            _seatingCapacity = 0;
            _seats = null;
        }

        public Flight(int flightId, DateTime date, string origin, string destination, DateTime departureTime, DateTime arrivalTime, int seatingCapacity, Seat[] seats)
        {
            this._flightId = flightId;
            this._date = date;
            this._origin = origin;
            this._destination = destination;
            this._departureTime = departureTime;
            this._arrivalTime = arrivalTime;
            this._seatingCapacity = seatingCapacity;
            _seats = seats;
        }

        public int FlightId
        {
            get => _flightId;
            set => _flightId = value;
        }

        public DateTime Date
        {
            get => _date;
            set => _date = value;
        }

        public string Origin
        {
            get => _origin;
            set => _origin = value;
        }

        public string Destination
        {
            get => _destination;
            set => _destination = value;
        }

        public DateTime DepartureTime
        {
            get => _departureTime;
            set => _departureTime = value;
        }

        public DateTime ArrivalTime
        {
            get => _arrivalTime;
            set => _arrivalTime = value;
        }

        public int SeatingCapacity
        {
            get => _seatingCapacity;
            set => _seatingCapacity = value;
        }

        public Seat[] Seats
        {
            get => _seats;
            set => _seats = value;
        }
    }

    /// <summary>
    /// Activity 1 ENDS
    /// </summary>
    /// Activity 2 Starts

    class Employee
    {
        private int _employeeId;
        private string _loginName;
        private string _password;
        private string _department;
        private string _firstname;
        private string _lastname;
        private Order _order;

        public Employee()
        {
            _employeeId = 0;
            _loginName = null;
            _password = null;
            _department = null;
            _firstname = null;
            _lastname = null;
            _order = null;
        }

        public Employee(int employeeId, string loginName, string password, string department, string firstname, string lastname)
        {
            _employeeId = employeeId;
            _loginName = loginName;
            _password = password;
            _department = department;
            _firstname = firstname;
            _lastname = lastname;
        }

        public int EmployeeId
        {
            get => _employeeId;
            set => _employeeId = value;
        }

        public string LoginName
        {
            get => _loginName;
            set => _loginName = value;
        }

        public string Password
        {
            get => _password;
            set => _password = value;
        }

        public string Department
        {
            get => _department;
            set => _department = value;
        }

        public string Firstname
        {
            get => _firstname;
            set => _firstname = value;
        }

        public string Lastname
        {
            get => _lastname;
            set => _lastname = value;
        }

        public Order Order
        {
            get => _order;
            set => _order = value;
        }

        public void Login()
        {
            
        }
    }

    class DepartmentManager: Employee
    {
        public DepartmentManager()
        {
        }

        public DepartmentManager(int employeeId, string loginName, string password, string department, string firstname, string lastname) : base(employeeId, loginName, password, department, firstname, lastname)
        {
            
        }

        public void ApprovePurchase()
        {
            
        }
    }

    class Order
    {
        private long _orderNo;
        private DateTime _orderDate;
        private string _status;
        private OrderItem[] _orderItems;

        public Order()
        {
            _orderNo = 0;
            _orderDate = new DateTime();
            _status = null;
            _orderItems = null;
        }

        public Order(long orderNo, DateTime orderDate, string status)
        {
            this._orderNo = orderNo;
            this._orderDate = orderDate;
            this._status = status;
        }

        public long OrderNo
        {
            get => _orderNo;
            set => _orderNo = value;
        }

        public DateTime OrderDate
        {
            get => _orderDate;
            set => _orderDate = value;
        }

        public OrderItem[] OrderItems
        {
            get => _orderItems;
            set => _orderItems = value;
        }

        public string Status
        {
            get => _status;
            set => _status = value;
        }

        public void AddItem()
        {
            
        }
        public void RemoveItem()
        {
            
        }
        public void SubmitOrder()
        {
            
        }
    }

    class OrderItem
    {
        private string _productNo;
        private int _quantity;
        private uint _unitPrice;
        private Product _product;

        public OrderItem()
        {
            _productNo = null;
            _quantity = 0;
            _unitPrice = 0;
            _product = null;
        }

        public OrderItem(string productNo, int quantity, uint unitPrice)
        {
            this._productNo = productNo;
            this._quantity = quantity;
            this._unitPrice = unitPrice;
        }

        public string ProductNo
        {
            get => _productNo;
            set => _productNo = value;
        }

        public int Quantity
        {
            get => _quantity;
            set => _quantity = value;
        }

        public uint UnitPrice
        {
            get => _unitPrice;
            set => _unitPrice = value;
        }

        public Product Product
        {
            get => _product;
            set => _product = value;
        }
    }

    class Product
    {
        private string _productNo;
        private string _productName;
        private string _category;
        private string _description;
        private string _unitPrice;
        private string _vedorCode;

        public Product()
        {
            _productNo = null;
            _productName = null;
            _category = null;
            _description = null;
            _unitPrice = null; 
            _vedorCode = null; 
        }

        public Product(string productNo, string productName, string category, string description, string unitPrice, string vedorCode)
        {
            this._productNo = productNo;
            this._productName = productName;
            this._category = category;
            this._description = description;
            this._unitPrice = unitPrice;
            this._vedorCode = vedorCode;
        }

        public string ProductNo
        {
            get => _productNo;
            set => _productNo = value;
        }

        public string ProductName
        {
            get => _productName;
            set => _productName = value;
        }

        public string Category
        {
            get => _category;
            set => _category = value;
        }

        public string Description
        {
            get => _description;
            set => _description = value;
        }

        public string UnitPrice
        {
            get => _unitPrice;
            set => _unitPrice = value;
        }

        public string VedorCode
        {
            get => _vedorCode;
            set => _vedorCode = value;
        }
    }

    internal class ProductCatalog
    {
        private Product[] _products;

        public ProductCatalog()
        {
            _products = null;
        }

        public ProductCatalog(Product[] products)
        {
            _products = products;
        }

        public void ListCategories()
        {
            
        }

        public void ListProducts()
        {
            
        }

        public Product[] Products
        {
            get => _products;
            set => _products = value;
        }
    }
    /// <summary>
    /// Activity 2 ENDS
    /// </summary>
    internal class Program
    {
        public static void Main(string[] args)
        {
        }
    }
}