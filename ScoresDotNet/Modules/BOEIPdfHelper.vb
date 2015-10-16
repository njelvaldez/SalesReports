Module BOEIPdfHelper
    Public Customer As New BoeiCustomer
    Public Product As New BoeiProduct
    Public Function GetCustomer(customername As String, customerdetail As String) As BoeiCustomer
        Customer.Customer = customername
        Customer.Product = GetProductName(customerdetail)
        Customer.Quantity = GetQuantity(customerdetail)
        Customer.UnitPrice = GetUnitPrice(customerdetail)
        Customer.Amount = GetAmount(customerdetail)
        Return Customer
    End Function
    Public Function GetProduct(productname As String, customerdetail As String) As BoeiProduct
        Customer.Product = productname
        Customer.Customer = "BOEI Customer"
        Customer.Amount = 1.0
        Customer.UnitPrice = 8.0
        Customer.Amount = 8.0
        Return product
    End Function
    'METHISOPRINOL (ISOPRINOSINE) 250MG 60ML 1 165.18 165.18
    'LAGUNDI (LAGUNDEX) 600MG CAP FORTE 60'S -0.57 241.09 -137.42
    Public Function GetProductName(line As String) As String
        Dim retval As String = ""
        Dim dotpos As Integer = 0
        Dim spcctr As Integer = 0
        dotpos = line.LastIndexOf(".")
        For revctr As Integer = dotpos To 1 Step -1
            If (line.Substring(revctr, 1).Equals(" ")) Then
                spcctr = spcctr + 1
            End If
            If spcctr = 3 Then
                retval = line.Substring(0, revctr)
                Exit For
            End If
        Next
        Return retval
    End Function
    'METHISOPRINOL (ISOPRINOSINE) 250MG 60ML 1 165.18 165.18
    Public Function GetQuantity(line As String) As Double
        Dim retval As String = ""
        Dim dotpos As Integer = 0
        Dim spcctr As Integer = 0
        Dim secondspc As Integer = 0
        dotpos = line.LastIndexOf(".")
        For revctr As Integer = dotpos To 1 Step -1
            If (line.Substring(revctr, 1).Equals(" ")) Then
                spcctr = spcctr + 1
                If spcctr = 2 Then
                    secondspc = revctr
                End If
            End If
            If spcctr = 3 Then
                retval = line.Substring(revctr, secondspc - revctr)
                Exit For
            End If
        Next
        Return retval
    End Function
    'METHISOPRINOL (ISOPRINOSINE) 250MG 60ML 1 165.18 165.18
    Public Function GetUnitPrice(line As String) As Double
        Dim retval As String = ""
        Dim dotpos As Integer = 0
        Dim spcctr As Integer = 0
        Dim firstspc As Integer = 0
        dotpos = line.LastIndexOf(".")
        For revctr As Integer = dotpos To 1 Step -1
            If (line.Substring(revctr, 1).Equals(" ")) Then
                spcctr = spcctr + 1
                If spcctr = 1 Then
                    firstspc = revctr
                End If
            End If
            If spcctr = 2 Then
                retval = line.Substring(revctr, (firstspc - revctr))
                Exit For
            End If
        Next
        Return retval
    End Function
    'METHISOPRINOL (ISOPRINOSINE) 250MG 60ML 1 165.18 165.18
    Public Function GetAmount(line As String) As Double
        Dim retval As String = ""
        Dim dotpos As Integer = 0
        dotpos = line.LastIndexOf(".")
        For revctr As Integer = dotpos To 1 Step -1
            If (line.Substring(revctr, 1).Equals(" ")) Then
                retval = line.Substring(revctr)
                Exit For
            End If
        Next
        Return retval
    End Function
End Module
