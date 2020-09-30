<?php
require 'Model\Autoloader.php';


use Club_Fromage\{
    Model\Buisness,
    Model\Autoloader,
    Model\Buisness\Avis,
    Model\Buisness\Fromage,
    Model\Buisness\Membre,
    Model\Buisness\Pays
};
Autoloader::register();

$tabAvis = array (
    "idMembre" =>1,
    "idFromage"=>5,
    "avis"=>"bof",
    "note"=>1
);

$tabFromage = array(
    "id" => 3,
    "idPays" =>85,
    "nom" => "Reblochon",
    "dureeAffinage" => '01-00-00',
    "dateCreation" => '1900-06_02',
    "image" => "uneImage",
    "recette" => "dknhfuiehgrezyègfryegtry",
    "histoire" => "fjenuizehfuizhyklsndciqsohfuihofgry"
);

$tabPays =array(
    "idPays" => 12,
    "nom" => "Abondance"
);

$tabMembre = array(
    "id" => 9,
    "nomUtilisateur" => "GROUSSAUD",
    "pseudo" => "agroussaud",
    "email" => "axel.groussaud@saintmichelannecy.fr",
    "motDePasse" => "********",
    "dateDerConnexion" => '2020-09-23',
    "dateeEntreeClub" => '2020-08-18',
    "description" => ""
);

$avistest = new Avis($tabAvis);
echo $avistest->getIdMembre()." ".$avistest->getIdFromage()." ".$avistest->getAvis()." ".$avistest->getNote();

$fromagetest = new Fromage($tabFromage);

