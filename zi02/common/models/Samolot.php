<?php

namespace common\models;

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
            [['model', 'rok_produkcji', 'liczba_miejsc'], 'required'],
            [['rok_produkcji'], 'date', 'format' => 'yyyy-MM-dd'],
			['rok_produkcji', 'compare', 'operator' => '<=', 'compareValue' => date('Y-m-d')],
            [['liczba_miejsc'], 'integer', 'min' => 0],
			[['liczba_miejsc'], 'string', 'max' => 8],
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
            'rok_produkcji' => 'Rok produkcji',
            'liczba_miejsc' => 'Liczba miejsc',
        ];
    }

	public function getNazwa()
	{
		return $this->model.'('.Yii::$app->formatter->asDate($this->rok_produkcji).')';
	}

    /**
     * @return \yii\db\ActiveQuery
     */
    public function getLots()
    {
        return $this->hasMany(Lot::className(), ['samolot_id' => 'id']);
    }
}
