<?php


namespace Club_Fromage\Model\Buisness;


class Avis
{
   private $_idMembre;
   private $_idFromage;
   private $_avis;
   private $_note;

    public function __construct(array $data)
    {
        $this->hydrate($data);
    }

    /**
     * @return mixed
     */
    public function getIdMembre()
    {
        return $this->_idMembre;
    }

    /**
     * @param mixed $idMembre
     */
    public function setIdMembre($idMembre)
    {
        $this->_idMembre = $idMembre;
    }

    /**
     * @return mixed
     */
    public function getIdFromage()
    {
        return $this->_idFromage;
    }

    /**
     * @param mixed $idFromage
     */
    public function setIdFromage($idFromage)
    {
        $this->_idFromage = $idFromage;
    }

    /**
     * @return mixed
     */
    public function getAvis()
    {
        return $this->_avis;
    }

    /**
     * @param mixed $avis
     */
    public function setAvis($avis)
    {
        $this->_avis = $avis;
    }

    /**
     * @return mixed
     */
    public function getNote()
    {
        return $this->_note;
    }

    /**
     * @param mixed $note
     */
    public function setNote($note)
    {
        $this->_note = $note;
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