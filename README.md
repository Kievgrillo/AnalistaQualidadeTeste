# AnalistaQualidadeTeste

CONSIDERAÇÕES DO CANDIDATO

Instruções para rodar a aplicação

-visual studio 2019
-sqlserver vinculado na visual studio (Enable-migrations e alteraçãe na pasta migrations para true) e (update-database, para criação do banco do sqlServer.)
-set a project na aplicação e rodar o IIS Express (Google chrome)
- quando a aplicação aparecer, der alguma erro de cara, verificar a URL, se caso tiver algum
caminho nela além do local, retirar esse caminho (bug do vs) e deixar somente o local ex: https://localhost:44304/,
que vai funcionar.
- os campos de textAreaFor (observação e descrição) você consegue aumentar os tamanho do campo, sem deixar ele estático,
não é boa prática, mas não consegui deixar ele estático com o tamanho recomendado.

Liguagens e metodologias usadas

- asp.net mvc 5
- bootstrap
- html
- autorização com autenticação
- identity
- scalffold
- monólito
- routes

Impeditivos

- autenticação com responsável via login
- paginação
- layout na lista e redirecionamento de links.
- botões de assumir tarefa e finalizar tarefa (acabei me confundindo com essa funcionalidade)
- botão editar


