SELECT COUNT(*) AS count
FROM ECOLI_DATA
WHERE (GENOTYPE & 2) = 0
AND (GENOTYPE & 1 <> 0 or GENOTYPE & 4 <> 0);