SELECT T5.descripcion, t2.descripcion, COUNT(T1.ID_MAT)
FROM Material T1, Tipo_Volumen T2, Prov_X_Mat T3, Proveedor T4, Paises T5
WHERE T1.id_mat = T3.id_mat
AND T1.tipo_vol = T2.id
AND T3.id_prov = T4.cod_proveedor
AND T4.pais = T5.id
AND T1.habilitado = 0
AND T4.habilitado = 0
GROUP BY T5.descripcion, t2.descripcion
ORDER BY 1, 2 ASC
--ORDER BY T1.id_mat ASC

SELECT T1.descrip, T1.id_mat, T3.id_prov
FROM Material T1, Tipo_Volumen T2, Prov_X_Mat T3, Proveedor T4, Paises T5
WHERE T1.id_mat = T3.id_mat
AND T1.tipo_vol = T2.id
AND T3.id_prov = T4.cod_proveedor
AND T4.pais = T5.id
AND T1.habilitado = 0
AND T4.habilitado = 0
--GROUP BY T5.descripcion, t2.descripcion
ORDER BY 2 ASC



SELECT COUNT(ID_MAT)
FROM Material

--T1.descrip, T2.descripcion, T4.razon_social, T5.descripcion



SELECT * FROM Material

SELECT * FROM Prov_X_Mat

SELECT * FROM Proveedor

SELECT * FROM Paises