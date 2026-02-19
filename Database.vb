Imports MySql.Data.MySqlClient

Module Database

    Private connectionString As String =
        "Server=localhost;" &
        "Port=3306;" &
        "Database=HotelManagementSystemDB;" &
        "Uid=root;" &
        "Pwd=;" &
        "SslMode=None;"

    Public Function GetConnection() As MySqlConnection
        Dim con As New MySqlConnection(connectionString)
        Return con
    End Function

End Module
