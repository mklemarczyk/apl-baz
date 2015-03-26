<?php

namespace app\models;

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
            [['id', 'imie', 'nazwisko'], 'required'],
            [['id'], 'integer'],
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
            'imie' => 'Imie',
            'nazwisko' => 'Nazwisko',
        ];
    }

    /**
     * @return \yii\db\ActiveQuery
     */
    public function getZakups()
    {
        return $this->hasMany(Zakup::className(), ['klient_id' => 'id']);
    }
}
