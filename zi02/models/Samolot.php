<?php

namespace app\models;

use Yii;

/**
 * This is the model class for table "samolot".
 *
 * @property integer $id
 * @property string $model
 * @property string $rok_produkcji
 * @property integer $liczba_miejsc
 *
 * @property Lot[] $lots
 */
class Samolot extends \yii\db\ActiveRecord
{
    /**
     * @inheritdoc
     */
    public static function tableName()
    {
        return 'samolot';
    }

    /**
     * @inheritdoc
     */
    public function rules()
    {
        return [
            [['id', 'model', 'rok_produkcji', 'liczba_miejsc'], 'required'],
            [['id', 'liczba_miejsc'], 'integer'],
            [['rok_produkcji'], 'safe'],
            [['model'], 'string', 'max' => 50]
        ];
    }

    /**
     * @inheritdoc
     */
    public function attributeLabels()
    {
        return [
            'id' => 'ID',
            'model' => 'Model',
            'rok_produkcji' => 'Rok Produkcji',
            'liczba_miejsc' => 'Liczba Miejsc',
        ];
    }

    /**
     * @return \yii\db\ActiveQuery
     */
    public function getLots()
    {
        return $this->hasMany(Lot::className(), ['samolot_id' => 'id']);
    }
}
