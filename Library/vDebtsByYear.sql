SELECT DISTINCT 
	Name, 
	Year
FROM   
	vUnsortedDebts
GROUP BY 
	Year, 
	Name 
WITH ROLLUP