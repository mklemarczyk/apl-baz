<?php

namespace app\models;

use Yii;

/**
 * This is the model class for table "bilet".
 *
 * @property integer $id
 * @property integer $klasa
 * @property integer $numer_miejsca
 * @property string $cena
 * @property string $imie
 * @property string $nazwisko
 * @property integer $lot_id
 * @property integer $zakup_id
 *
 * @property Lot $lot
 * @property Zakup $zakup
 */
class Bilet extends \yii\db\ActiveRecord
{
    /**
     * @inheritdoc
     */
    public static function tableName()
    {
        return 'bilet';
    }

    /**
     * @inheritdoc
     */
    public function rules()
    {
        return [
            [['id', 'klasa', 'numer_miejsca', 'cena', 'imie', 'nazwisko', 'lot_id', 'zakup_id'], 'required'],
            [['id', 'klasa', 'numer_miejsca', 'lot_id', 'zakup_id'], 'integer'],
            [['cena'], 'number'],
            [['imie', 'nazwisko'], 'string', 'max' => 255]
        ];
    }

    /**
     * @inheritdoc
     */
    public function attributeLabels()
    {
        return [
            'id' => 'ID',
            'klasa' => 'Klasa',
            'numer_miejsca' => 'Numer Miejsca',
            'cena' => 'Cena',
            'imie' => 'Imie',
            'nazwisko' => 'Nazwisko',
            'lot_id' => 'Lot ID',
            'zakup_id' => 'Zakup ID',
        ];
    }

    /**
     * @return \yii\db\ActiveQuery
     */
    public function getLot()
    {
        return $this->hasOne(Lot::className(), ['id' => 'lot_id']);
    }

    /**
     * @return \yii\db\ActiveQuery
     */
    public function getZakup()
    {
        return $this->hasOne(Zakup::className(), ['id' => 'zakup_id']);
    }
}
