Add-Type -AssemblyName Microsoft.Data.Sqlite
$conn = [Microsoft.Data.Sqlite.SqliteConnection]::new('Data Source=ContosoDashboard.db')
$conn.Open()
$cmd = $conn.CreateCommand()
$cmd.CommandText = 'SELECT name FROM sqlite_master WHERE type=''table'' ORDER BY name;'
$reader = $cmd.ExecuteReader()
while ($reader.Read()) { Write-Host $reader.GetString(0) }
$conn.Close()
