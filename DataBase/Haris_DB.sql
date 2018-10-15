CREATE TABLE TBL_USER(
	UserID int NOT NULL PRIMARY KEY,
	firstname varchar(225) Not NULL,
	surname varchar(225) NOT NULL,
	email varchar(320),
	phone int,
	city varchar(225),
	country varchar(225),
	username varchar(225) NOT NULL,
	pass varchar(225) NOT NULL
	);

CREATE TABLE TBL_SC_ITEMS(
	itemID int NOT NULL PRIMARY KEY,
	item_name varchar(225) NOT NULL,
	price float NOT NULL,
	info varchar(320)
	);

CREATE TABLE TBL_VENDOR(
	Vendor_ID int not null primary key,
	phone int not null,
	address_ varchar(320) not null,
	companyName varchar(225) not null,
	companyType varchar(225) not null,
	country varchar(225) not null,
	city varchar(225) not null,
	titl varchar(225) not null,
	firstname varchar(225) not null,
	surname varchar(225) not null,
	email varchar(225) not null
	);

CREATE TABLE TBL_PURCHASE_ORDER(
	POID int NOT NULL PRIMARY KEY,
	notes varchar(225),
	userID INT references TBL_USER(UserID),
	tax int,
	delivery_date date not null,
	created_date date not null,
	terms varchar(320),
	delivery_address varchar(225),
	vendorID int references TBL_VENDOR(Vendor_ID),
	total float
	);
	 
CREATE TABLE TBL_PO_ITEMS(
	POID int NOT NULL references TBL_PURCHASE_ORDER(POID),
	itemID int NOT NULL references TBL_SC_ITEMS(itemID),
	PRIMARY KEY(POID,itemID),
	quantity int not null,
	);

CREATE TABLE TBL_RECEIVING_REPORT(
	RRID int not null primary key,
	delivery_date date not null,
	created_date date not null,
	terms varchar(320),
	POID int  references TBL_PURCHASE_ORDER(POID),
	notes varchar(320),
	total float
	);

CREATE TABLE TBL_RECEIVED_ITEMS(
	RRID int NOT NULL references TBL_RECEIVING_REPORT(RRID),
	itemID int NOT NULL references TBL_SC_ITEMS(itemID),
	quantity int not null,
	PRIMARY KEY(RRID, itemID)
	);

CREATE TABLE TBL_INVOICE(
	invoiceID int not null primary key,
	POID int not null references TBL_PURCHASE_ORDER(POID),
	created_date date not null,
	due_date date not null,
	info varchar(320),
	vendorID INT NOT NULL REFERENCES TBL_VENDOR(Vendor_ID),
	total float,
	discount float
	);

CREATE TABLE TBL_INVOICE_ITEMS(
	invoiceID int NOT NULL references TBL_INVOICE(invoiceID),
	itemID int NOT NULL references TBL_SC_ITEMS(itemID),
	quantity int not null,
	PRIMARY KEY(invoiceID, itemID)
	);

CREATE TABLE TBL_RECEIPT(
	receiptID INT NOT NULL PRIMARY KEY,
	amount float not null,
	printDate date not null
);




