<?php


namespace Club_Fromage\Model\Buisness;


class Fromage
{
   private $_id;
   private $_idPays;
   private $_nom;
   private $_dureeAffinage;
   private $_dateCreation;
   private $_image;
   private $_recette;
   private $_histoire;

    public function __construct(array $data)
    {
        $this->hydrate($data);
    }

    /**
     * @return mixed
     */
    public function getId()
    {
        return $this->_id;
    }

    /**
     * @param mixed $id
     */
    public function setId($id)
    {
        $this->_id = $id;
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

    /**
     * @return mixed
     */
    public function getDureeAffinage()
    {
        return $this->_dureeAffinage;
    }

    /**
     * @param mixed $dureeAffinage
     */
    public function setDureeAffinage($dureeAffinage)
    {
        $this->_dureeAffinage = $dureeAffinage;
    }

    /**
     * @return mixed
     */
    public function getDateCreation()
    {
        return $this->_dateCreation;
    }

    /**
     * @param mixed $dateCreation
     */
    public function setDateCreation($dateCreation)
    {
        $this->_dateCreation = $dateCreation;
    }

    /**
     * @return mixed
     */
    public function getImage()
    {
        return $this->_image;
    }

    /**
     * @param mixed $image
     */
    public function setImage($image)
    {
        $this->_image = $image;
    }

    /**
     * @return mixed
     */
    public function getRecette()
    {
        return $this->_recette;
    }

    /**
     * @param mixed $recette
     */
    public function setRecette($recette)
    {
        $this->_recette = $recette;
    }

    /**
     * @return mixed
     */
    public function getHistoire()
    {
        return $this->_histoire;
    }

    /**
     * @param mixed $histoire
     */
    public function setHistoire($histoire)
    {
        $this->_histoire = $histoire;
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