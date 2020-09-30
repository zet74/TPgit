<?php


namespace Club_Fromage\Model\Buisness;


class Pays
{
   private $_idPays;
   private $_nom;

    public function __construct(array $data)
    {
        $this->hydrate($data);
    }

    /**
     * @return mixed
     */
    public function getIdPays()
    {
        return $this->_idPays;
    }

    /**
     * @param mixed $idPays
     */
    public function setIdPays($idPays)
    {
        $this->_idPays = $idPays;
    }

    /**
     * @return mixed
     */
    public function getNom()
    {
        return $this->_nom;
    }

    /**
     * @param mixed $nom
     */
    public function setNom($nom)
    {
        $this->_nom = $nom;
    }





    private function hydrate(array $donnees)
    {
        foreach ($donnees as $key => $value)
        { // On récupère le nom du setter correspondant à l'attribut
            $method = 'set'.ucfirst($key);
            // Si le setter correspondant existe.
            if (method_exists($this, $method))
            {
                // On appelle le setter.
                $this->$method($value);
            }
        }
    }
}