# A simple web app C# ASP.NET with localDB

## Como configurar o DB

* Baixar e instalar **SqlLocalDB** - https://msdn.microsoft.com/en-us/sqlserver2014express
* No **windowsUpdate instalar todas as atualizações microsoft .NET** (em especial SP1, SP2 e 4.0)
* no **cmd** digitar (no meu caso a versao criada foi 12.0.2000.8):
  * sqlLocalDb c agendadb
* para iniciar:
  * sqlLocalDb s agendadb
* para parar:
  * sqlLocalDb p agendadb
* para mais informacoes:
  * sqlLocalDb info agendadb
  * **copie o pipe** (exemplo do meu pipe): np:\\.\pipe\LOCALDB#SH0FA34D\tsql\query

### Microsoft Visual Studio

Para visualizar os dados e poder executar o SQL, adicione uma connexão com o BD - Tools > Connect to Database... > Microsoft SQL Server (Data Provider for SQL Server) > Continue. Coloque em Server name: **(localdb)\agendadb** > Test Connection > OK (pode ser usado o valor do pipe, qualquer dúvida veja o video: https://www.youtube.com/watch?v=VDLQPD2AV_E)

No painel Server Explorer, clique com o botão direito no BD dentro de Data Connections e selecione **New Query** e coloque o **conteúdo que está no arquivo Scripts SQL\agenda.Table.sql** e clique na set verde execute (Ctrl + Shift + E). A resposta de sucesso deve vir logo abaixo. 

#### Fontes de pesquisa:

* Pre-requisitos para rodar o LocalDB: https://www.mssqltips.com/sqlservertip/2694/getting-started-with-sql-server-2012-express-localdb/
* LocalDB.exe commands: https://msdn.microsoft.com/en-us/library/hh212961.aspx
* LocalDB .mdf files path: https://msdn.microsoft.com/en-us/library/hh510202(v=sql.120).aspx
* Connection strings examples for .config file: http://www.connectionstrings.com/search/?cx=partner-pub-0496710909277617%3A3214075191&cof=FORID%3A10&ie=UTF-8&q=localdb