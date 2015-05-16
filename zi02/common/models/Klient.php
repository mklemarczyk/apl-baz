<?php

namespace common\models;

use Yii;

/**
 * This is the model class for table "klient".
 *
 * @property integer $id
 * @property string $imie
 * @property string $nazwisko
 *
 * @property Zakup[] $zakups
 */
class Klient extends \yii\db\ActiveRecord
{
    /**
     * @inheritdoc
     */
    public static function tableName()
    {
        return 'klient';
    }

    /**
     * @inheritdoc
     */
    public function rules()
    {
        return [
            [['imie', 'nazwisko'], 'required'],
            [['imie', 'nazwisko'], 'string', 'length' => [3, 255]]
        ];
    }

    /**
     * @inheritdoc
     */
    public function attributeLabels()
    {
        return [
            'id' => 'ID',
            'imie' => 'Imie',
            'nazwisko' => 'Nazwisko',
        ];
    }

	public function getNazwa()
	{
		return $this->nazwisko.' '.$this->imie;
	}

    /**
     * @return \yii\db\ActiveQuery
     */
    public function getZakups()
    {
        return $this->hasMany(Zakup::className(), ['klient_id' => 'id']);
    }
}
