INSERT INTO dbo.Promocao (TIPO_PROMO, QTD_LEVE_PROMO, QTD_PAGUE_PROMO, VLR_PAGUE, DESC_PROMO)
VALUES (1, 3, NULL, 10, 'Leve 3 Pague 10 Reais')
GO

INSERT INTO dbo.Promocao (TIPO_PROMO, QTD_LEVE_PROMO, QTD_PAGUE_PROMO, VLR_PAGUE, DESC_PROMO)
VALUES (2, 3, 2, NULL, 'Pague 2 Leve 3')
GO

INSERT INTO dbo.Promocao (TIPO_PROMO, QTD_LEVE_PROMO, QTD_PAGUE_PROMO, VLR_PAGUE, DESC_PROMO)
VALUES (2, 15, 2, NULL, 'leve 15 pague 2')
GO



INSERT INTO dbo.Produto (ID_PROMO, NOME, PRECO)
VALUES (1, 'Shampoo', 5)
GO

INSERT INTO dbo.Produto (ID_PROMO, NOME, PRECO)
VALUES (1, 'condicionador', 15)
GO

INSERT INTO dbo.Produto (ID_PROMO, NOME, PRECO)
VALUES (1, 'óleo', 7.35)
GO

INSERT INTO dbo.Produto (ID_PROMO, NOME, PRECO)
VALUES (2, 'acetona', 3.4)
GO

INSERT INTO dbo.Produto (ID_PROMO, NOME, PRECO)
VALUES (2, 'carvão', 12.25)
GO

INSERT INTO dbo.Produto (ID_PROMO, NOME, PRECO)
VALUES (3, 'duzia ovo', 15)
GO

INSERT INTO dbo.Produto (ID_PROMO, NOME, PRECO)
VALUES (1, 'pimenta', 2)
GO
