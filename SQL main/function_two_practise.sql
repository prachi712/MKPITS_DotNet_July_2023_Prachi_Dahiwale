CREATE FUNCTION udfNet_Sales(  
    @quantity INT,  
    @price DEC(10,2),  
    @discount DEC(3,2)  
)  
RETURNS DEC(10,2)  
AS   
BEGIN  
    RETURN @quantity * @price * (1 - @discount);  
END;   