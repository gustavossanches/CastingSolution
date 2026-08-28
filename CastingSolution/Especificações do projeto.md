
Problemas do cliente

1 - cliente perde muito tempo na hora de montar um casting de promotores para envio as agencias que estao contratando, e 
    tambem o fato de tudo que tem sobre promotores que trabalham com ele fica tudo no celular aonde pode se perder 
    muitas coisas ou conversas, a ideia é que criamos um sistema aonde tera todos os promotores que trabalham para 
    agencia dele, e podera cadastrar novos aonde ficara salvo todas caracteristicas e fotos dos promotores e tambem detalhes
    de como foi sua atuação nos trabalhos anteriores, na parte de lista de promotores sempre ficara os promotores favoritos 
    ou os que tem mais execuções de trabalhos, na parte de geração de casting tera que montar um documento parecido com este 
    com varios promotores 

2 - nao iremos precisar por a parte de localização, somente os dados do promotor pois este documento gerado vai ser 
    oque ele ira mandar para seus clientes, na parte de fotos sempre tea que por no minimo 4 os 5 fotos aonde de pra ver 
    bem o promotores essa foto é somente um modelo pra sabermos do que estamos falando, quando ele receber o o retorno do 
    cliente, ele tem que poder fazer alterações automaticas nesse doc, por exemplo remover um promotor e por outro no lugar, 
    as fotos tem que seguir um padrao para nao alterar o tamanho do documento
    . ainda na parte de visualização de promotores precisamos fazer um ranking de promotores, produtores, e de modelos, 
        tambem tera que ter um espaço de documentos aonde podera receber informação ou nao pois tem promotores que tem 
        documentos de NBR ou de segurança do trabalho ou certificado dos bombeiros que tambem é sempre necessario ter 
        arquivados esses docs.


--
podemos usar tipo uma tagzinha (badge) no card do perfil dos cara indicando se é favorito, mostrando as NR que tem, acho que tenho um projeto com essas tagzinha, se tu nao entender o que quero dizer te mostro depois

    - PROMOTOR 
        - Id 
        - Documentos - ICollection<DocumentoPromotor>
        - Fotos - ICollection<FotoPromotor>

        - Nome
        - Telefone
        - Email
        - DataNascimento
        - Cidade
        - Função principal

        - Altura (cm)
        - CorOlhos
        - CorCabelo
        - Genero (M/F/Outro)

        - TamanhoCamiseta
        - TamanhoCalca

        - Status (Ativo/Inativo)  
    
        - Observacoes (texto livre) - 

        - IsFavorito (bool)  
        - Nota
    
        ____
        . adicionar/excluir promotor ao sistema
        . listar todos os promotores
        . na lista de promotores, podemos mostrar um cardzinho com fotos deles e algumas tags (como eu disse la no inicio)
            essa lista vai somente mostrar os cards deles e ter um botao para ver mais detalhes.
    ------------------------------------------------------------------------------------------------------ 

    - DocumentoPromotor
        - Id (PK)
        - PromotorId (FK)
        - CaminhoArquivo  
        - TipoDocumento (enum: NBR, SegurancaTrabalho, CertificadoBombeiros, RG, seila mais o que tiver)  
        - DataUpload - 
        - Status (Valido/Vencido/Pendente)
        - Obs
    ------------------------------------------------------------------------------------------------------
    - CastingPromotor 
        - Id (PK)
        - PromotorId (FK) 
        - CastingId (FK)  
        - Status (Confirmado/Recusado) 
        - Pagamento
        - Função realizada
        - Ordem

    ------------------------------------------------------------------------------------------------------
    - Pagamento
        - Id (PK)
        - CastingPromotor (FK)

        - Valor
        - Status (Pago, Não pago)
        - DataPrevista
        - DataPagamento
        - Comprovante

    ------------------------------------------------------------------------------------------------------
    - Evento
        - Id (PK)  
        - ListaCasting ICollection<Casting>   
        - Local  
        - Cliente (nome da empresa/organizador)
        - Detalhes do evento(serviço que sera prestado)  
        - DataInicio  
        - DataFim  
        - ValorPromotores - soma dos promotores 
        - ValorCobrado - valor cobrado do cliente

    ------------------------------------------------------------------------------------------------------
    - Casting
        - Id (PK)  
        - Promotores ICollection<CastingPromotor> 

        - Area - recepção, limpeza 
        - Status (Confirmado/Aguardando cliente)  
        - Maximo de promotores - se algum promotor aceitar após o limite, ele não poderá participar do casting (deve receber mensagem explicando isso )
        - DataInicio - data com hora
        - DataFim - data com hora,  adicionar hora tembem nessas datas? pros cara que trabalha saber a hora de chegar e sair
        ____

    ------------------------------------------------------------------------------------------------------
        - FotoPromotor
    - Id
    - PromotorId
    - CaminhoArquivo
    - IsPrincipal
    - Ordem
    - DataUpload  

------------------------------------------------------------------------------------------------------ 
    - Casting
        futuramente usar " Status (Confirmado/Aguardando cliente/Aguardando promotores) " para mensagens automaticas por wpp
             
    ----

    - CastingPromotor
        futuramente Status (Confirmado/Recusado/Aguardando) - na hora de montar o casting, o usuario vai escolher os promotores e
            mandar mensagem de wpp para eles, onde devem confirmar ou recusar, a parte de criar o PDF do casting só deve ficar
            disponivel após os promotores terem confirmado a participação, caso algum recuse o usuario deve escolher outro 
            promotor e enviar novamente a mensagem. logo quando o casting é criado, o status do promotor é Aguardando.



