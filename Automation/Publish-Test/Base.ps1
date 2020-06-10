#Armazenar caminho atual
$Raiz = (Get-Item -Path ".\").FullName

Write-Output "Atulizando API Gateway"

cd ..\..\Gateway\d1000.Gateway.API
Start-Process  .\publish.bat

cd $Raiz

#################################

Write-Output "Atulizando API Base"

cd ..\..\Services\Base\d1000.Services.Base.API
Start-Process  .\publish.bat

cd $Raiz

#################################

Write-Output "Atulizando API Clientes"

cd ..\..\Services\Clientes\d1000.Services.Clientes.API
Start-Process  .\publish.bat

cd $Raiz

#################################

Write-Output "Atulizando API Farmácia Popular"

cd ..\..\Services\FarmaciaPopular\d1000.Services.FarmaciaPopular.API
Start-Process  .\publish.bat

cd $Raiz

#################################

Write-Output "Atulizando API Orçamento"

cd ..\..\Services\Orcamento\d1000.Services.Orcamento.API
Start-Process  .\publish.bat

cd $Raiz

#################################

Write-Output "Atulizando API Pedido Loja"

cd ..\..\Services\PedidoLoja\d1000.Services.PedidoLoja.API
Start-Process  .\publish.bat

cd $Raiz

#################################

Write-Output "Atulizando API Produtos"

cd ..\..\Services\Produtos\d1000.Services.Produtos.API
Start-Process  .\publish.bat

cd $Raiz

#################################

Write-Output "Atulizando API SNGPC"

cd ..\..\Services\SNGPC\d1000.Services.SNGPC.API
Start-Process  .\publish.bat

cd $Raiz

Write-Output "Atualizacao concluida"

CMD /c PAUSE






